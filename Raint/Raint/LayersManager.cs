using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Raint
{
    class LayersManager
    {
       public List<Bitmap> layers;
       public Bitmap finalImage;
       MainWindow Form;

        public LayersManager(MainWindow Form)
        {
            this.Form = Form; 
            layers = new List<Bitmap>();
            finalImage = new Bitmap(Form.pictureBox_ForeGroundBlend.Width, Form.pictureBox_ForeGroundBlend.Height);
            Graphics g = Graphics.FromImage(finalImage);
            g.Clear(Color.White);
            g.Dispose();
            Form.pictureBox_ForeGroundBlend.Image = finalImage;
            Form.pictureBox_ForeGroundBlend.Update();
        }

        public Bitmap Overlay() {
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                foreach (Bitmap layer in layers)
                {
                    g.DrawImage(layer, new Rectangle(Form.pictureBox_ForeGroundBlend.Bounds.X, Form.pictureBox_ForeGroundBlend.Bounds.Y, Form.pictureBox_ForeGroundBlend.Width, Form.pictureBox_ForeGroundBlend.Height));
                }
               // g.Clear(Color.RoyalBlue);
            }
            // Form.pictureBox_MainPic.Image = finalImage;
            return (finalImage);
            //Form.pictureBox_MainPic.Update();
        }

        public void UpdateLayer(Bitmap update, int currentLayer)
        {
            using (Graphics g = Graphics.FromImage(layers.ElementAt(currentLayer)))
            {
                g.DrawImage(update, new Rectangle(Form.pictureBox_ForeGroundBlend.Bounds.X, Form.pictureBox_ForeGroundBlend.Bounds.Y, Form.pictureBox_ForeGroundBlend.Width, Form.pictureBox_ForeGroundBlend.Height));
            }
            //Overlay();
        }
    }
}
