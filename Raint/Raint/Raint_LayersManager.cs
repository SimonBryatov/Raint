using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Raint
{
    partial class MainWindow
    {
        public List<Bitmap> layers, layersToView;
        public Bitmap BackImage, FrontImage, NewLayer;
        int[] selected;

        public void InitializeLayers()
        {
            layers = new List<Bitmap>();

            ListView.View = View.Details;
            ListView.Columns.Add("Layers");
            ListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            ListView.SmallImageList = ImageList;
            
            AddLayer();
            BackImage = new Bitmap(pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height);
            FrontImage = new Bitmap(pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height);
            Graphics g = Graphics.FromImage(BackImage);
            g.Clear(Color.Transparent);
            g.Dispose();
            pictureBox_BackGroundBlend.Image = BackImage;
            pictureBox_ForeGroundBlend.Image = FrontImage;
        }

        public void Overlay(int currentLayer)
        {
            using (Graphics g = Graphics.FromImage(BackImage))
            {
                g.Clear(Color.Transparent);
                for (int i = 0; i < currentLayer; i++)
                {
                    g.DrawImage(layers.ElementAt(i), new Rectangle(pictureBox_ForeGroundBlend.Bounds.X, pictureBox_ForeGroundBlend.Bounds.Y, pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height));
                }

            }
            using (Graphics g = Graphics.FromImage(FrontImage))
            {
                g.Clear(Color.Transparent);
                for (int i = currentLayer + 1; i < layers.Count; i++)
                {
                    g.DrawImage(layers.ElementAt(i), new Rectangle(pictureBox_ForeGroundBlend.Bounds.X, pictureBox_ForeGroundBlend.Bounds.Y, pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height));
                }
                pictureBox_LayerDrawArea.Image = layers[currentLayer];
            }
        }

        public void AddLayer()
        {
            NewLayer = new Bitmap(pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height);
            using (Graphics g = Graphics.FromImage(NewLayer))
            {
                g.Clear(Color.Transparent);
            }
            layers.Add(NewLayer);
            ImageList.Images.Add(layers.ElementAt(layers.Count - 1));
            string name = string.Format("Layer {0}", layers.Count - 1);
            ListView.Items.Add(name, layers.Count - 1);
            ListView.Refresh();
            currentLayer = layers.Count - 1;
            pictureBox_LayerDrawArea.Image = layers.ElementAt(currentLayer);
            if (currentLayer != 0)
            {
                Overlay(currentLayer);
            }
            ListView.SelectedItems.Clear();
            ListView.Items[currentLayer].Focused = true;
            ListView.Items[currentLayer].Selected = true;

            ListView.Select();
        }
 
        public void DeleteLayers(bool all)
        {
            int[] ind_to_change = new int[layers.Count - ListView.SelectedIndices.Count];
            if (!all)
            {
                int i = 0;
                selected = new int[ListView.SelectedIndices.Count];
                if (selected.Length == 0) return;
                ListView.SelectedIndices.CopyTo(selected, 0);
                for (int ind = 0; ind < layers.Count; ind++)
                {   if (!selected.Contains(ind))
                    {
                        ind_to_change[i] = ind;
                        i++;
                    }
                }
                i = 0;
                foreach (int ind in selected)
                {
                    ListView.Items.RemoveAt(ind - i);
                    ImageList.Images.RemoveAt(ind - i);
                    layers[ind - i].Dispose();
                    layers.RemoveAt(ind - i);
                    i++;
                }
                ListView.Refresh();
            } else
            {
                int count = ListView.Items.Count;
                for (int i = count-1; i >= 0; i--)
                {
                    ListView.Items.RemoveAt(i);
                    ImageList.Images.RemoveAt(i);
                    layers[i].Dispose();
                    layers.RemoveAt(i);
                }
            }
            if (layers.Count != 0)
            {
                currentLayer = selected[0] != 0 ? currentLayer = selected[0] - 1 : currentLayer = 0;
            }
            else
            {
                AddLayer();
                currentLayer = 0;
            }

            if (!all)
            {
                int i = 0;
                for (int index = 0; index < UndoList.Indexes.Count; index++)
                {
                    if (selected.Contains(UndoList.Indexes[index]))
                    {
                        UndoList.Bitmaps.RemoveAt(index);
                        UndoList.Indexes.RemoveAt(index);
                    }
                }

                for (int index = 0; index < RedoList.Indexes.Count; index++)
                {
                    if (selected.Contains(RedoList.Indexes[index]))
                    {
                        RedoList.Bitmaps.RemoveAt(index);
                        RedoList.Indexes.RemoveAt(index);
                    }
                }
  
                foreach (int ind in ind_to_change)
                {
                    for (int index = 0; index < UndoList.Indexes.Count; index++)
                    {
                        if (ind == UndoList.Indexes[index])
                        {
                            UndoList.Indexes[index] = i;
                        }
                    }
                    for (int index = 0; index < RedoList.Indexes.Count; index++)
                    {
                        if (ind == RedoList.Indexes[index])
                        {
                            RedoList.Indexes[index] = i;
                        }
                    }
                    i++;
                }
            }
            pictureBox_LayerDrawArea.Image = layers.ElementAt(currentLayer);
            Overlay(currentLayer);
            ListView.Items[currentLayer].Focused = true;
            ListView.Items[currentLayer].Selected = true;
            ListView.Select();
               
            

        }

        public void SelectLayer()
        {
            if (ListView.SelectedItems.Count > 0)
            {
                currentLayer = ListView.SelectedIndices[0];
                pictureBox_LayerDrawArea.Image = layers.ElementAt(currentLayer);
                Overlay(currentLayer);
            }
        }

        public void LayerDown()
        {
            if (currentLayer != 0)
            {
                Bitmap prev_layer = new Bitmap(layers[currentLayer -1]);
                layers[currentLayer - 1] = layers[currentLayer];
                layers[currentLayer] = prev_layer;
                ListViewItem moving_item = ListView.Items[currentLayer];
                ListView.Items.Remove(moving_item);
                ListView.Items.Insert(currentLayer - 1, moving_item);
                int old_index = currentLayer;
                currentLayer = currentLayer - 1;
                Overlay(currentLayer);
                ListView.Refresh();
                ListView.Items[currentLayer].Focused = true;
                ListView.Items[currentLayer].Selected = true;
                ListView.Select();
                for (int index = 0; index < UndoList.Indexes.Count; index++)
                {
                    if (UndoList.Indexes[index] == old_index)
                    {
                        UndoList.Indexes[index] = currentLayer;
                    }
                    else
                    {
                        if (UndoList.Indexes[index] == currentLayer)
                        {
                            UndoList.Indexes[index] = old_index;
                        }
                    }
                }

                for (int index = 0; index < RedoList.Indexes.Count; index++)
                {
                    if (RedoList.Indexes[index] == old_index)
                    {
                        RedoList.Indexes[index] = currentLayer;
                    }
                    else
                    {
                        if (RedoList.Indexes[index] == currentLayer)
                        {
                            RedoList.Indexes[index] = old_index;
                        }
                    }
                }
            }
        }

        public void LayerUp()
        {
            if (currentLayer != layers.Count - 1)
            {
                Bitmap next_layer = new Bitmap(layers[currentLayer + 1]);
                layers[currentLayer + 1] = layers[currentLayer];
                layers[currentLayer] = next_layer;
                ListViewItem moving_item = ListView.Items[currentLayer];
                ListView.Items.Remove(moving_item);
                ListView.Items.Insert(currentLayer + 1, moving_item);
                int old_index = currentLayer;
                currentLayer = currentLayer + 1;
                Overlay(currentLayer);
                ListView.Refresh();
                ListView.SelectedItems.Clear();
                ListView.Items[currentLayer].Focused = true;
                ListView.Items[currentLayer].Selected = true;
                ListView.Select();

                for (int index = 0; index < UndoList.Indexes.Count; index++)
                {
                    if (UndoList.Indexes[index] == old_index)
                    {
                        UndoList.Indexes[index] = currentLayer;
                    }
                    else
                    {
                        if (UndoList.Indexes[index] == currentLayer)
                        {
                            UndoList.Indexes[index] = old_index;
                        }
                    }
                }

                for (int index = 0; index < RedoList.Indexes.Count; index++)
                {
                    if (RedoList.Indexes[index] == old_index)
                    {
                        RedoList.Indexes[index] = currentLayer;
                    }
                    else
                    {
                        if (RedoList.Indexes[index] == currentLayer)
                        {
                            RedoList.Indexes[index] = old_index;
                        }
                    }
                }
            }
        }

        Bitmap ReadyToSave()
        {
            Bitmap bmp = new Bitmap(pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                for (int i = 0; i < layers.Count; i++)
                {
                    g.DrawImage(layers.ElementAt(i), new Rectangle(pictureBox_ForeGroundBlend.Bounds.X, pictureBox_ForeGroundBlend.Bounds.Y, pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height));
                }
            }
            return bmp;
        }
        




    }
}
