using GrafikaSemestralna.Hra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GrafikaSemestralna.Grafika
{
    public class PredmetGraficky
    {
        private System.Drawing.Image predmet;
        private String nazov { get; set; }
        private int x;
        private int y;
        private int sizeX;
        private int sizeY;
        private bool visible { get; set; }
        private PictureBox pictureBox;
        private string ImagePath { get; }

        private EventHandler clickHandler;


        public PredmetGraficky(String nazov, String cesta, int x, int y, int sizeX, int sizeY, EventHandler clickHandler)
        {
            predmet = new Bitmap(@cesta);
            this.x = x;
            this.y = y;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.nazov = nazov;
            pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(sizeX, sizeY), // Set the initial dimensions
                Location = new Point(x, y),
                BackColor = Color.Transparent
            };
            this.clickHandler = clickHandler;
            ImagePath = cesta;
        }




        public void LoadImage()
        {
            try
            {
                pictureBox.Image = System.Drawing.Image.FromFile(ImagePath);
                pictureBox.Click += clickHandler;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image '{ImagePath}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        public void HideClickableImage()
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(HideClickableImage));
            }
            else
            {
                pictureBox.Visible = false;
                pictureBox.Click -= clickHandler;
            }
            
        }
        public void ShowClickableImage()
        {
            pictureBox.Visible = true;
            pictureBox.Click += clickHandler;
        }
        public void PouziSa(Zvieratko zvieratko)
        {
            switch (nazov)
            {
                case "wc":
                    zvieratko.GetPotreba("wc").Zvis(100);
                    break;
                case "tv":
                    //zvieratko.GetPotreba("zabava").Zvis(50);
                    zvieratko.GetPotreba("energia").Zniz(20);
                    break;
                case "chladnicka":
                    zvieratko.GetPotreba("hlad").Zvis(80);
                    zvieratko.GetPotreba("energia").Zniz(10);
                    break;
                case "sprcha":
                    zvieratko.GetPotreba("hygiena").Zvis(100);
                    zvieratko.GetPotreba("energia").Zniz(5);
                    break;
                case "postel":
                    zvieratko.GetPotreba("hygiena").Zniz(20);
                    zvieratko.GetPotreba("hlad").Zniz(20);
                    zvieratko.GetPotreba("wc").Zniz(20);
                    zvieratko.GetPotreba("energia").Zvis(100);
                    break;
            }
        }
        public String Nazov { get { return nazov; } }
        private System.Drawing.Image Predmet { get { return predmet; } }
        public PictureBox PictureBox { get { return pictureBox; } }
    }
}
