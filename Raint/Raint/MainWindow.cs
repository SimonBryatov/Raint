using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Raint
{
    public partial class MainWindow : Form
    {
        Color paintColor;

        bool choose = false;
        bool draw = false;

        Item currentItem;
        int val = 0;
        int x, y;
        int lx, ly;
        int brushSize;
        int limit_actions_to_store = 5;
        double H, S, Br;
        int currentLayer;
        Bitmap temp_storage;
        TimeSpan sec = TimeSpan.FromMilliseconds(1000);
        TimeSpan t;
        public class UndoRedoStruct
        {
            public List<Bitmap> Bitmaps;
            public List<int> Indexes;
           public UndoRedoStruct()
            {
                Bitmaps = new List<Bitmap>();
                Indexes = new List<int>();
            }
        }
        UndoRedoStruct UndoList;
        UndoRedoStruct RedoList;

        public MainWindow()
        {
            InitializeComponent();
            t = new TimeSpan(0, 0, Convert.ToInt32(Properties.Settings.Default.Seconds)/123);
            if (Program.goTrial)
            {
                //label_Time.Show();
                TrialTimer.Start();
            }
            //Smoothing_Timer.Start();
            UndoList = new UndoRedoStruct();
            RedoList = new UndoRedoStruct();
            currentLayer = -1;
            InitializeLayers();
            pictureBox_BackGroundBlend.BackColor = Color.White;
            pictureBox_BackGroundBlend.Controls.Add(pictureBox_LayerDrawArea);
            pictureBox_LayerDrawArea.BackColor = Color.Transparent;
            pictureBox_LayerDrawArea.Location = new Point(0, 0);
            pictureBox_BackGroundBlend.Controls.Add(pictureBox_ForeGroundBlend);
            pictureBox_LayerDrawArea.Controls.Add(pictureBox_ForeGroundBlend);
            pictureBox_ForeGroundBlend.Location = new Point(0, 0);
            pictureBox_ForeGroundBlend.BackColor = Color.Transparent;
            pictureBox_BackGroundBlend.MouseMove += pictureBox_LayerDrawArea_MouseMove;
            pictureBox_BackGroundBlend.Click += pictureBox_LayerDrawArea_Click;
            pictureBox_ForeGroundBlend.MouseUp += pictureBox_LayerDrawArea_MouseUp;
            pictureBox_ForeGroundBlend.MouseDown += pictureBox_LayerDrawArea_MouseDown;
            pictureBox_LayerDrawArea.MouseMove += pictureBox_ForeGroundBlend_MouseMove;
            pictureBox_LayerDrawArea.Click += pictureBox_ForeGroundBlend_Click;
            pictureBox_LayerDrawArea.MouseDown += pictureBox_ForeGroundBlend_MouseDown;
            pictureBox_LayerDrawArea.MouseUp += pictureBox_ForeGroundBlend_MouseUp;
            paintColor = Color.Black;
            pictureBox_CurrentColor.BackColor = paintColor;
            currentItem = Item.Pencil;
        }

        public enum Item
        {
            Pencil, Brush, Eraser, Line, Rectangle, Ellipse, ColorPicker, FloodFill 
        }



        private void pictureBox_ForeGroundBlend_Click(object sender, EventArgs e)
        {
            switch(currentItem)
            {
                case Item.ColorPicker:
                    Bitmap bmp = new Bitmap(pictureBox_ForeGroundBlend.Width, pictureBox_ForeGroundBlend.Height);
                    Graphics g = Graphics.FromImage(bmp);
                    Rectangle rect = pictureBox_ForeGroundBlend.RectangleToScreen(pictureBox_ForeGroundBlend.ClientRectangle);
                    g.CopyFromScreen(rect.Location, Point.Empty, pictureBox_ForeGroundBlend.Size);
                    g.Dispose();                   
                    paintColor = bmp.GetPixel(x, y);
                    pictureBox_CurrentColor.BackColor = paintColor;
                    break;
                case Item.FloodFill:
                    bmp = new Bitmap(layers[currentLayer]);
                    FloodFill(bmp, x, y, paintColor);
                    layers[currentLayer] = bmp;
                    pictureBox_LayerDrawArea.Image = bmp; 
                    break;

            }
        }

        private void pictureBox_ForeGroundBlend_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentItem != Item.ColorPicker)
            {
                SaveLastLayer();
            }
            draw = true;
            x = e.X;
            y = e.Y;
            lx = e.X;
            ly = e.Y;
            temp_storage = new Bitmap(layers[currentLayer]);
             
        }

        private void pictureBox_ForeGroundBlend_MouseMove(object sender, MouseEventArgs e)
        {
            label_X.Text = e.X.ToString();
            label_Y.Text = e.Y.ToString();
            if (draw)
            {
                if (currentItem == Item.Line || currentItem == Item.Rectangle || currentItem == Item.Ellipse)
                { 
                    //val++;
                    //if (val == 6)
                    //{
                        layers[currentLayer].Dispose();
                        layers[currentLayer] = new Bitmap(temp_storage);
                    //    val = 0;
                    //}
                }
                Graphics g = Graphics.FromImage(layers.ElementAt(currentLayer));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                switch (currentItem)
                {
                    case Item.Line:
                        Pen pL = new Pen(paintColor, brushSize);
                        pL.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pL.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                        pL.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(pL, new Point(x, y), new Point(e.X, e.Y));
                        break;
                    case Item.Rectangle:
                        g.FillRectangle(new SolidBrush(paintColor), new Rectangle(
                               Math.Min(e.X, x),
                               Math.Min(e.Y, y),
                               Math.Abs(e.X - x),
                               Math.Abs(e.Y - y)));
                        lx = e.X;
                        ly = e.Y;
                        break;
                    case Item.Ellipse:
                        g.FillEllipse(new SolidBrush(paintColor), new Rectangle(
                              Math.Min(e.X, x),
                              Math.Min(e.Y, y),
                              Math.Abs(e.X - x),
                              Math.Abs(e.Y - y)));
                        lx = e.X;
                        ly = e.Y;
                        break; 
                    case Item.Pencil:
                        Pen p = new Pen(paintColor, brushSize);
                        p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        p.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                        p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(p, new Point(lx, ly), new Point(e.X, e.Y));
                        lx = e.X;
                        ly = e.Y;
                        break;
                    case Item.Brush:
                        Pen p1 = new Pen(paintColor, brushSize+3);
                        p1.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                        p1.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                        g.DrawLine(p1, new Point(lx, ly), new Point(e.X, e.Y));
                        lx = e.X;
                        ly = e.Y;
                        break;
                    case Item.Eraser:
                        Pen Ep = new Pen(Color.Transparent, brushSize + 20);
                        Brush m_ClearBrush = m_ClearBrush = new SolidBrush(Color.FromArgb(0, Color.White));
                        g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                        Ep.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        Ep.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                        Ep.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(Ep, new Point(lx, ly), new Point(e.X, e.Y));
                        lx = e.X;
                        ly = e.Y;
                        break;

                }
                pictureBox_LayerDrawArea.Image = layers.ElementAt(currentLayer);
                pictureBox1.Image = layers.ElementAt(currentLayer);
                g.Dispose();
            } 
        }

        private void Smoothing_Timer_Tick(object sender, EventArgs e)
        {
            //if (draw)
            //{
            //    val++;
            //            //if (currentItem == Item.Line || currentItem == Item.Rectangle || currentItem == Item.Ellipse)
            //            //{
            //            //    layers[currentLayer].Dispose();
            //            //    layers[currentLayer] = new Bitmap(temp_storage);
            //            //}
            //            //Graphics g = Graphics.FromImage(layers.ElementAt(currentLayer));
            //            //Pen pL = new Pen(paintColor, brushSize);
            //            //g.DrawLine(pL, new Point(x, y), new Point(Control.MousePosition.X, Control.MousePosition.Y));
            //            //g.Flush();
            //            // break;
            //    }
        }

        private void pictureBox_ForeGroundBlend_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            if (currentItem == Item.Line || currentItem == Item.Rectangle || currentItem == Item.Ellipse)
            {
                layers[currentLayer].Dispose();
                layers[currentLayer] = new Bitmap(temp_storage);
            }
            temp_storage.Dispose();
            Graphics g = Graphics.FromImage(layers.ElementAt(currentLayer));
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            switch (currentItem)
            {

                case Item.Line:
                    lx = e.X;
                    ly = e.Y;
                    Pen p = new Pen(paintColor, brushSize);
                    p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    p.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                    p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLine(p, new Point(x, y), new Point(e.X, e.Y));
                    g.Dispose();
                    break;
                case Item.Rectangle:
                    g.FillRectangle(new SolidBrush(paintColor), new Rectangle(
                               Math.Min(e.X, x),
                               Math.Min(e.Y, y),
                               Math.Abs(e.X - x),
                               Math.Abs(e.Y - y)));
                    break;
                case Item.Ellipse:
                    g.FillEllipse(new SolidBrush(paintColor), new Rectangle(
                               Math.Min(e.X, x),
                               Math.Min(e.Y, y),
                               Math.Abs(e.X - x),
                               Math.Abs(e.Y - y)));
                    break;
            }
            pictureBox_LayerDrawArea.Image = layers.ElementAt(currentLayer);
            g.Dispose();
            ListView.Refresh();
        }

        
        private void button_Line_Click(object sender, EventArgs e)
        {
            currentItem = Item.Line;
        }

        private void button_Rectangle_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = Item.Rectangle;
        }

        private void button_Ellipse_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = Item.Ellipse;
        }

        private void button_Pencil_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = Item.Pencil;
        }

        private void button_Brush_Click(object sender, EventArgs e)
        {
            if (!Program.goTrial)
            {
                currentItem = Item.Brush;
            }
            else MessageBox.Show("Not Available in Trial Version!", "Activate full version!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackBar_brushSize_Scroll(object sender, EventArgs e)
        {
            brushSize = trackBar_brushSize.Value; 
        }

        private void alpha_Scroll(object sender, EventArgs e)
        {
            paintColor = Color.FromArgb(paintColor.R, paintColor.G, paintColor.B, Hue.Value);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        private void pictureBox_ColorPalette_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        private void button_Eraser_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = Item.Eraser;
        }

        private void button_ColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Program.goTrial)
            {
                currentItem = Item.ColorPicker;
            }
            else MessageBox.Show("Not Available in Trial Version!", "Activate full version!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button_AddLayer_MouseClick(object sender, MouseEventArgs e)
        {
            AddLayer();
        }

        private void button_DeleteLayer_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteLayers(false);
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            SelectLayer();
        }

        public void SaveLastLayer()
        {
            RedoList.Bitmaps.Clear();
            RedoList.Indexes.Clear();
            if (UndoList.Bitmaps.Count < limit_actions_to_store)
            {
                UndoList.Bitmaps.Add(new Bitmap(layers[currentLayer]));
                UndoList.Indexes.Add(currentLayer);
            }
            else
            {
                UndoList.Bitmaps[0].Dispose();
                UndoList.Bitmaps.RemoveAt(0);
                UndoList.Indexes.RemoveAt(0);
                UndoList.Bitmaps.Add(new Bitmap(layers[currentLayer]));
                UndoList.Indexes.Add(currentLayer);
            }
        }

        private void Undo_MouseClick(object sender, MouseEventArgs e)
        {
            if (UndoList.Bitmaps.Count != 0)
            {
                int last_changedLayer = UndoList.Indexes.Last();
                RedoList.Bitmaps.Insert(0, new Bitmap(layers[last_changedLayer]));
                RedoList.Indexes.Insert(0, last_changedLayer);
                layers[last_changedLayer].Dispose();
                layers[last_changedLayer] = new Bitmap(UndoList.Bitmaps.Last());
                UndoList.Bitmaps.RemoveAt(UndoList.Bitmaps.Count - 1);
                UndoList.Indexes.RemoveAt(UndoList.Indexes.Count - 1);
                Overlay(currentLayer);
            }
        }

        private void button_Redo_MouseClick(object sender, MouseEventArgs e)
        {
            if (RedoList.Bitmaps.Count != 0)
            {
                int last_changedLayer = RedoList.Indexes[0];
                UndoList.Indexes.Add(last_changedLayer);
                UndoList.Bitmaps.Add(new Bitmap(layers[last_changedLayer]));
                layers[last_changedLayer].Dispose();
                layers[last_changedLayer] = new Bitmap(RedoList.Bitmaps[0]);
                RedoList.Bitmaps.RemoveAt(0);
                RedoList.Indexes.RemoveAt(0);
                Overlay(currentLayer);
                
            }
        }

        private void pictureBox_ColorPalette_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox_ColorPalette.Image.Clone();
            paintColor = bmp.GetPixel(e.X, e.Y);
            Hue.Value = (int)paintColor.GetHue() * 2 + Convert.ToInt32(paintColor.GetHue() * 2 * 0.39);
            pictureBox_CurrentColor.BackColor = paintColor;
        }


        private void pictureBox_ColorPalette_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose)
            {
                if (e.X >= pictureBox_ColorPalette.Bounds.Left &&
                    e.X < pictureBox_ColorPalette.Bounds.Width &&
                    e.Y >= pictureBox_ColorPalette.Bounds.Top &&
                    e.Y < pictureBox_ColorPalette.Bounds.Height)
                {
                    Bitmap bmp = (Bitmap)pictureBox_ColorPalette.Image.Clone();
                    paintColor = bmp.GetPixel(e.X, e.Y);
                    Hue.Value = (int)paintColor.GetHue()*2 + Convert.ToInt32(paintColor.GetHue() * 2 * 0.39);
                    pictureBox_CurrentColor.BackColor = paintColor;
                }
            }
        }

        private void button_Fill_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Program.goTrial)
            {
                currentItem = Item.FloodFill;
                SaveLastLayer();
            }
            else MessageBox.Show("Not Available in Trial Version!", "Activate full version!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Save_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Program.goTrial)
            {
                SavePic();
            } else MessageBox.Show("Not Available in Trial Version!", "Activate full version!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SavePic()
        {
            Bitmap bmp = ReadyToSave();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|Jpeg files|*jpg|Bitmap files|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
            bmp.Dispose();
        }

        private void Open_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Program.goTrial)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want yo save your drawing?", "Don't loose your drawing!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SavePic();
                }
                Bitmap bmp;
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png|Png files|*.png|Jpeg files|*jpg|Bitmap files|*.bmp";
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bmp = new Bitmap(Image.FromFile(o.FileName), pictureBox_LayerDrawArea.Size);
                    pictureBox_BackGroundBlend.Size = bmp.Size;
                    pictureBox_ForeGroundBlend.Size = bmp.Size;
                    pictureBox_LayerDrawArea.Size = bmp.Size;
                    DeleteLayers(true);
                    layers[0] = new Bitmap(bmp);
                    Overlay(0);
                    AddLayer();
                    bmp.Dispose();
                }
            }
            else MessageBox.Show("Not Available in Trial Version!", "Activate full version!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Blank_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want yo save your drawing?", "Don't loose your drawing!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SavePic();
            }
            UndoList.Bitmaps.Clear();
            UndoList.Indexes.Clear();
            RedoList.Bitmaps.Clear();
            RedoList.Indexes.Clear();
            DeleteLayers(true);
        }

        private void TrialTimer_Tick(object sender, EventArgs e)
        {
            
            t+=sec;
            label_Time.Text = t.TotalSeconds.ToString();
            Properties.Settings.Default.Seconds = ((t.TotalSeconds)*123).ToString();
            Properties.Settings.Default.Save();
         
        }

        private void ClearLayer_MouseClick(object sender, MouseEventArgs e)
        {
            SaveLastLayer();
            using (Graphics g = Graphics.FromImage(layers[currentLayer]))
            {
                g.Clear(currentLayer == 0 ? Color.White : Color.Transparent);
                Overlay(currentLayer);
            }
        }

        private void Hue_Scroll(object sender, EventArgs e)
        {
            ColorToHSB(paintColor, out H, out S, out Br);
            H = Hue.Value * 0.36;
            paintColor = ColorFromHSB(H, S, Br);
            pictureBox_CurrentColor.BackColor = paintColor;
        }

        private void Saturation_Scroll(object sender, EventArgs e)
        {
            ColorToHSB(paintColor, out H, out S, out Br);
            S = Saturation.Value * 0.001;
            paintColor = ColorFromHSB(H, S, Br);
            pictureBox_CurrentColor.BackColor = paintColor;
        }

        private void Brightness_Scroll(object sender, EventArgs e)
        {
            ColorToHSB(paintColor, out H, out S, out Br);
            Br = Brightness.Value * 0.001;
            paintColor = ColorFromHSB(H, S, Br);
            pictureBox_CurrentColor.BackColor = paintColor;
        }

        public static void ColorToHSB(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public static Color ColorFromHSB(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }


        public void FloodFill(Bitmap bmp, int x, int y, Color new_color)
        {

            Color old_color = bmp.GetPixel(x, y);

            if (old_color == new_color) return;


            Stack<Point> points = new Stack<Point>();
            points.Push(new Point(x, y));
            bmp.SetPixel(x, y, new_color);


            while (points.Count > 0)
            {
                Point pt = points.Pop();
                if (pt.X > pictureBox_ForeGroundBlend.Bounds.X) CheckPoint(bmp, points, pt.X - 1, pt.Y,
                   old_color, new_color);
                if (pt.Y > pictureBox_ForeGroundBlend.Bounds.Y) CheckPoint(bmp, points, pt.X, pt.Y - 1,
                    old_color, new_color);
                if (pt.X < pictureBox_ForeGroundBlend.Bounds.Width - 1) CheckPoint(bmp, points, pt.X + 1, pt.Y,
                     old_color, new_color);
                if (pt.Y < pictureBox_ForeGroundBlend.Bounds.Height - 1) CheckPoint(bmp, points, pt.X, pt.Y + 1,
                     old_color, new_color);
            }
        }

        private void CheckPoint(Bitmap bmp, Stack<Point> points, int x, int y,
    Color old_color, Color new_color)
        {
            if (bmp.GetPixel(x, y) == old_color)
            {
                points.Push(new Point(x, y));
                bmp.SetPixel(x, y, new_color);
            }
        }

        //public void FloodFill(Bitmap bmp, int x, int y, Color newColor)
        //{
        //    Stack<Point> pixels = new Stack<Point>();
        //    Color oldColor = bmp.GetPixel(x, y);
        //    pixels.Push(new Point(x, y));

        //    while (pixels.Count > 0)
        //    {
        //        Point a = pixels.Pop();
        //        if (a.X <= pictureBox_ForeGroundBlend.Bounds.Width - 1 && a.X >= 0 &&
        //                a.Y <= pictureBox_ForeGroundBlend.Bounds.Height - 1 && a.Y >= 0)//make sure we stay within bounds
        //        {

        //            if (bmp.GetPixel(a.X, a.Y) == oldColor)
        //            {
        //                bmp.SetPixel(a.X, a.Y, newColor);
        //                pixels.Push(new Point(a.X - 1, a.Y));
        //                pixels.Push(new Point(a.X + 1, a.Y));
        //                pixels.Push(new Point(a.X, a.Y - 1));
        //                pixels.Push(new Point(a.X, a.Y + 1));
        //            }
        //        }
        //    }
        //    return;
        //}


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label_Alpha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_LayerDrawArea_Click(object sender, EventArgs e)
        {

        }

        private void button_LayerDown_MouseClick(object sender, MouseEventArgs e)
        {
            LayerDown();
        }

        private void button_LayerUp_MouseClick(object sender, MouseEventArgs e)
        {
            LayerUp();
        }

        private void pictureBox_LayerDrawArea_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_LayerDrawArea_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_LayerDrawArea_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //public static void HSVToRGB(double H, double S, double V, out double R, out double G, out double B)
        //{
        //    if (H == 1.0)
        //    {
        //        H = 0.0;
        //    }

        //    double step = 1.0 / 6.0;
        //    double vh = H / step;

        //    int i = (int)System.Math.Floor(vh);

        //    double f = vh - i;
        //    double p = V * (1.0 - S);
        //    double q = V * (1.0 - (S * f));
        //    double t = V * (1.0 - (S * (1.0 - f)));

        //    switch (i)
        //    {
        //        case 0:
        //            {
        //                R = V;
        //                G = t;
        //                B = p;
        //                break;
        //            }
        //        case 1:
        //            {
        //                R = q;
        //                G = V;
        //                B = p;
        //                break;
        //            }
        //        case 2:
        //            {
        //                R = p;
        //                G = V;
        //                B = t;
        //                break;
        //            }
        //        case 3:
        //            {
        //                R = p;
        //                G = q;
        //                B = V;
        //                break;
        //            }
        //        case 4:
        //            {
        //                R = t;
        //                G = p;
        //                B = V;
        //                break;
        //            }
        //        case 5:
        //            {
        //                R = V;
        //                G = p;
        //                B = q;
        //                break;
        //            }
        //        default:
        //            {
        //                // not possible - if we get here it is an internal error
        //                throw new ArgumentException();
        //            }
        //    }
        //}
    }

}
