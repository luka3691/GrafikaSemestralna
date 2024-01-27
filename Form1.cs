using GrafikaSemestralna.Grafika;
using GrafikaSemestralna.Hra;
using GrafikaSemestralna.Hra.Exceptions;
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

        System.Windows.Forms.Timer timerUpdater;
        private System.Timers.Timer timer;
        private DateTime startTime;
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
            grafickyPotreby.Add("zivot", zivotBar);
            
            grafickePredmety.Add("chladnicka", new PredmetGraficky("chladnicka", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\chladnicka.png", 290, 70, 125, 210, ImageClickedHandler));
            grafickePredmety.Add("sprcha", new PredmetGraficky("sprcha", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sprcha.png", 310, 60, 150, 180, ImageClickedHandler));
            grafickePredmety.Add("postel", new PredmetGraficky("postel", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\postel.png", 150, 190, 205, 125, ImageClickedHandler));
            grafickePredmety.Add("wc", new PredmetGraficky("wc", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\wc.png", 75, 165, 110, 165, ImageClickedHandler));

            grafickePredmety.Add("sever", new PredmetGraficky("sever", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\sever.png", 225, 108, 125, 208, ImageClickedHandler));
            grafickePredmety.Add("juh", new PredmetGraficky("juh", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\juh.png", 225, 332, 125, 62, ImageClickedHandler));
            grafickePredmety.Add("vychod", new PredmetGraficky("vychod", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\vychod.png", 488, 82, 82, 243, ImageClickedHandler));
            grafickePredmety.Add("zapad", new PredmetGraficky("zapad", "C:\\Users\\luka3\\source\\repos\\GrafikaSemestralna\\Images\\zapad.png", 5, 62, 74, 243, ImageClickedHandler));

           
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

            timerUpdater = new System.Windows.Forms.Timer();
            timerUpdater.Tick += (sender, e) => UpdateProgressBar(grafickyPotreby, zvieratko, this);
            timerUpdater.Interval = 1000;

            timerUpdater.Start();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            startTime = DateTime.Now;
            timer.Start();

        }

        static void UpdateProgressBar(Dictionary<string, ProgressBar> progressBars, Zvieratko zvieratik, Form1 form)
        {
            foreach (var progressBarEntry in progressBars)
            {
                string progressBarKey = progressBarEntry.Key;

                progressBarEntry.Value.Invoke((MethodInvoker)delegate
                {
                    progressBars[progressBarKey].Value = zvieratik.GetPotreba(progressBarKey).GetAktualnePercent();
                    if (progressBars[progressBarKey].Value == 0 && progressBarKey == "zivot")
                    {
                        form.EndGame(false);
                    }

                });
            }
        }

        private void ImageClickedHandler(object sender, EventArgs e)
        {
           PictureBox clickedPictureBox = (PictureBox)sender;
            PredmetGraficky clickedImage = grafickePredmety.Values.FirstOrDefault(img => img.PictureBox == clickedPictureBox);

            if (clickedImage.Nazov == "sever" || clickedImage.Nazov == "juh" || clickedImage.Nazov == "vychod" || clickedImage.Nazov == "zapad")
            {
                zvieratko.SetAktualnaMiestnost(zvieratko.GetAktualnaMiestnost().Vychody[clickedImage.Nazov]);
                repaintHraciuPlochu();
            }
            else
            {
                clickedImage.PouziSa(zvieratko);
            }

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


        public void EndGame(bool vyhra)
        {
            if (hraciaPlocha.InvokeRequired)
            {
                hraciaPlocha.Invoke(new Action(() => EndGame(vyhra)));
            }
            else
            {
                timer.Stop();
                timerUpdater.Stop();
                hraciaPlocha.BackgroundImage = null;
                hraciaPlocha.Refresh();
                foreach (var clickableImage in grafickePredmety)
                {
                    clickableImage.Value.HideClickableImage();
                }
                if (vyhra)
                {
                    vyhraText.Visible = true;
                }
                else
                {
                    prehraText.Visible = true;
                }
            }
        }


        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;

            if (elapsedTime.TotalSeconds >= 60)
            {

                EndGame(true);
            }

            UpdateTimeLabel(elapsedTime);
        }

        private void UpdateTimeLabel(TimeSpan elapsed)
        {
            string formattedTime = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
            if (timeLabel.InvokeRequired)
            {
                timeLabel.Invoke((MethodInvoker)delegate { timeLabel.Text = formattedTime; });
            }
            else
            {
                timeLabel.Text = formattedTime;
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