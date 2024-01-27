using GrafikaSemestralna.Grafika;
using GrafikaSemestralna.Hra;
using GrafikaSemestralna.Hra.Potreby;
using GrafikaSemestralna.Prostredie;
using GrafikaSemestralna.Prostredie.Predmety;
using System;
using System.ComponentModel;
using System.Timers;
namespace GrafikaSemestralna
{
    public partial class Form1 : Form
    {
        private Zvieratko zvieratko;
        private Prostredia prostredie;
        private Dictionary<string, PredmetGraficky> grafickePredmety;
        private Dictionary<string, ProgressBar> grafickyPotreby;
        private BackgroundWorker backgroundWorker1;
        //private List<PredmetGraficky> grafickePredmety;
        public Form1()
        {
            InitializeComponent();
            prostredie = new Prostredia();
            zvieratko = new Zvieratko("luka", prostredie);

            //grafickePredmety = new List<PredmetGraficky>();
            grafickePredmety = new Dictionary<string, PredmetGraficky>();
            grafickyPotreby = new Dictionary<string, ProgressBar>();
            grafickyPotreby.Add("energia", energiaBar);
            grafickyPotreby.Add("hlad", hladBar);
            grafickyPotreby.Add("wc", wcBar);
            grafickyPotreby.Add("hygiena", hygienaBar);
            // Add clickable images to the list (replace with the actual paths to your image files)
            /*
            grafickePredmety.Add(new PredmetGraficky("chladnicka", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\chladnicka.png", 290, 70, 125, 210, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("sprcha", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sprcha.png", 310, 60, 150, 180, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("postel", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\postel.png", 150, 190, 205, 125, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("wc", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\wc.png", 75, 165, 110, 165, ImageClickedHandler)); grafickePredmety.Add(new PredmetGraficky("wc", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\wc.png", 75, 165, 110, 165, ImageClickedHandler));

            grafickePredmety.Add(new PredmetGraficky("sever", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sever.png", 225, 108, 125, 208, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("juh", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\juh.png", 225, 332, 125, 62, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("vychod", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\vychod.png", 488, 82, 82, 243, ImageClickedHandler));
            grafickePredmety.Add(new PredmetGraficky("zapad", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\zapad.png", 5, 62, 74, 243, ImageClickedHandler));
            */
            grafickePredmety.Add("chladnicka", new PredmetGraficky("chladnicka", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\chladnicka.png", 290, 70, 125, 210, ImageClickedHandler));
            grafickePredmety.Add("sprcha", new PredmetGraficky("sprcha", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sprcha.png", 310, 60, 150, 180, ImageClickedHandler));
            grafickePredmety.Add("postel", new PredmetGraficky("postel", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\postel.png", 150, 190, 205, 125, ImageClickedHandler));
            grafickePredmety.Add("wc", new PredmetGraficky("wc", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\wc.png", 75, 165, 110, 165, ImageClickedHandler));

            grafickePredmety.Add("sever", new PredmetGraficky("sever", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sever.png", 225, 108, 125, 208, ImageClickedHandler));
            grafickePredmety.Add("juh", new PredmetGraficky("juh", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\juh.png", 225, 332, 125, 62, ImageClickedHandler));
            grafickePredmety.Add("vychod", new PredmetGraficky("vychod", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\vychod.png", 488, 82, 82, 243, ImageClickedHandler));
            grafickePredmety.Add("zapad", new PredmetGraficky("zapad", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\zapad.png", 5, 62, 74, 243, ImageClickedHandler));

            // Load and display images in the PictureBox
            foreach (var clickableImage in grafickePredmety)
            {
                clickableImage.Value.LoadImage();
                hraciaPlocha.Controls.Add(clickableImage.Value.PictureBox);
                clickableImage.Value.HideClickableImage();
            }

            foreach (var predmetiky in zvieratko.GetAktualnaMiestnost().Predmety.Keys)
            {
                grafickePredmety[predmetiky].ShowClickableImage();
            }
            foreach (var predmetiky in zvieratko.GetAktualnaMiestnost().Vychody.Keys)
            {
                grafickePredmety[predmetiky].ShowClickableImage();
            }

            // Add the PictureBox to the form
            //Controls.Add(hraciaPlocha);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) => UpdateProgressBar(grafickyPotreby, zvieratko);
            timer.Interval = 2000;
            timer.Start();
            /*
                        predmety.Add("sprcha", new PredmetGraficky("sprcha", "images/sprcha.png", 290, 70, 125, 210));
                        predmety.Add("chladnicka", new PredmetGraficky("chladnicka", "images/chladnicka.png", 310, 120, 150, 180));
                        predmety.Add("postel", new PredmetGraficky("postel", "images/postel.png", 150, 190, 205, 125));
                        predmety.Add("wc", new PredmetGraficky("wc", "images/wc.png", 75, 165, 110, 165));
                        */
        }
        
        static void UpdateProgressBar(Dictionary<string, ProgressBar> progressBars, Zvieratko zvieratik)
        {
            // Ensure UI updates are performed on the main UI thread
            foreach (var progressBarEntry in progressBars)
            {
                string progressBarKey = progressBarEntry.Key;

                progressBarEntry.Value.Invoke((MethodInvoker)delegate {
                    // Extract the value from the corresponding textbox and convert it to an integer
                    
                    
                        // Update the progress bar value with the extracted value
                        progressBars[progressBarKey].Value = zvieratik.GetPotreba(progressBarKey).GetAktualnePercent();

                    
                });
            }
        }

        private void ImageClickedHandler(object sender, EventArgs e)
        {
            // Handle the click event here
            PictureBox clickedPictureBox = (PictureBox)sender;
            //PredmetGraficky clickedImage = grafickePredmety.Find(img => img.PictureBox == clickedPictureBox);
            PredmetGraficky clickedImage = grafickePredmety.Values.FirstOrDefault(img => img.PictureBox == clickedPictureBox);

            if (clickedImage.Nazov == "sever" || clickedImage.Nazov == "juh" || clickedImage.Nazov == "vychod" || clickedImage.Nazov == "zapad")
            {
                zvieratko.SetAktualnaMiestnost(zvieratko.GetAktualnaMiestnost().Vychody[clickedImage.Nazov]);
                repaintHraciuPlochu();
            }
            else
            {

            }

            // Hide the clickable image and disable the click handler
            // clickedImage.HideClickableImage();
        }
        private void repaintHraciuPlochu()
        {
            foreach (var clickableImage in grafickePredmety)
            {
                clickableImage.Value.HideClickableImage();
            }

            foreach (var predmetiky in zvieratko.GetAktualnaMiestnost().Predmety.Keys)
            {
                grafickePredmety[predmetiky].ShowClickableImage();
            }
            foreach (var predmetiky in zvieratko.GetAktualnaMiestnost().Vychody.Keys)
            {
                grafickePredmety[predmetiky].ShowClickableImage();
            }
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}