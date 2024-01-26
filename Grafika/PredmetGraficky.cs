using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Grafika
{
    public class PredmetGraficky
    {
        private Image predmet;
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
            }; // Set the initial position};
            this.clickHandler = clickHandler;
            ImagePath = cesta;
        }




        public void LoadImage()
        {
            try
            {
                // Load the image from the specified path
                pictureBox.Image = Image.FromFile(ImagePath);
                // Attach the Click event handler
                pictureBox.Click += clickHandler;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, invalid image format, etc.)
                MessageBox.Show($"Error loading image '{ImagePath}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HideClickableImage()
        {
            // Hide the PictureBox and detach the Click event handler
            pictureBox.Visible = false;
            pictureBox.Click -= clickHandler;
        }
        public void ShowClickableImage()
        {
            // Hide the PictureBox and detach the Click event handler
            pictureBox.Visible = true;
            pictureBox.Click += clickHandler;
        }
        public String Nazov { get { return nazov; } }
        private Image Predmet { get { return predmet; } }
        public PictureBox PictureBox { get { return pictureBox; } }
    }
}
