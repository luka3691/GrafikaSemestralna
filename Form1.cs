using GrafikaSemestralna.Grafika;
using GrafikaSemestralna.Hra;
using GrafikaSemestralna.Prostredie;

namespace GrafikaSemestralna
{
    public partial class Form1 : Form
    {
        private Zvieratko zvieratko;
        private Prostredia prostredie;
        //private Dictionary<string, PredmetGraficky> predmety;
        private List<PredmetGraficky> grafickePredmety;
        public Form1()
        {
            InitializeComponent();
            prostredie = new Prostredia();
            /*
            PictureBox pictureSever = new PictureBox();
            pictureSever.Width = 160;
            pictureSever.Height = 380;
            Bitmap image = new Bitmap("C:\\Images\\Creek.jpg");
            pictureSever.Dock = DockStyle.Fill;
            pictureSever.Image = (Image)image;
            Controls.Add(pictureSever);

            
            */
            grafickePredmety = new List<PredmetGraficky>();

            // Add clickable images to the list (replace with the actual paths to your image files)
            grafickePredmety.Add(new PredmetGraficky("chladnicka", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\chladnicka.png", 290, 70, 125, 210, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("sprcha", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sprcha.png", 310, 120, 150, 180, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("postel", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\postel.png", 150, 190, 205, 125, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("wc", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\wc.png", 75, 165, 110, 165, ImageClickedHandler)); grafickePredmety.Add(new PredmetGraficky("wc", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\wc.png", 75, 165, 110, 165, ImageClickedHandler));

            grafickePredmety.Add(new PredmetGraficky("sever", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sever.png", 225, 108, 125, 208, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("juh", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\juh.png", 225, 332, 125, 62, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("vychod", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\vychod.png", 488, 82, 82, 243, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("zapad", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\zapad.png", 21, 82, 74, 243, ImageClickedHandler));

            // Load and display images in the PictureBox
            foreach (var clickableImage in grafickePredmety)
            {
                clickableImage.LoadImage();
                hraciaPlocha.Controls.Add(clickableImage.PictureBox);
            }

            // Add the PictureBox to the form
            Controls.Add(hraciaPlocha);



            /*
            predmety.Add("sprcha", new PredmetGraficky("sprcha", "images/sprcha.png", 290, 70, 125, 210));
            predmety.Add("chladnicka", new PredmetGraficky("chladnicka", "images/chladnicka.png", 310, 120, 150, 180));
            predmety.Add("postel", new PredmetGraficky("postel", "images/postel.png", 150, 190, 205, 125));
            predmety.Add("wc", new PredmetGraficky("wc", "images/wc.png", 75, 165, 110, 165));
            */
        }
        private void ImageClickedHandler(object sender, EventArgs e)
        {
            // Handle the click event here
            PictureBox clickedPictureBox = (PictureBox)sender;
            PredmetGraficky clickedImage = grafickePredmety.Find(img => img.PictureBox == clickedPictureBox);

            // Example: Show a message box with the clicked image path
            MessageBox.Show($"Image Clicked: {clickedImage.nazov}");

            // Hide the clickable image and disable the click handler
            // clickedImage.HideClickableImage();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hraciaPlocha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hraciaPlocha_MouseClick(object sender, MouseEventArgs e)
        {
            //ProjectData.CurrentMousePosition = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            zvieratko.PouziPredmet("chladnicka");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}