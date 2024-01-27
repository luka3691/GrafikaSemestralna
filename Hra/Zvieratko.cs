using GrafikaSemestralna.Prostredie.Predmety;
using GrafikaSemestralna.Prostredie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrafikaSemestralna.Hra.Potreby;
using System.Timers;

namespace GrafikaSemestralna.Hra
{
    public class Zvieratko
    {
        private readonly string meno;
        private Miestnost aktualnaMiestnost;
        private ZijeZvieratko stavZvieratka;
        private List<IStavPotreby> potreby;

        public Zvieratko(string meno, Prostredia prostredie)
        {
            this.meno = meno;
            this.aktualnaMiestnost = prostredie.GetStartovaciaMiestnost();
            this.stavZvieratka = ZijeZvieratko.ZIJE;

            this.potreby = new List<IStavPotreby>
            {
                new Potreba("energia"),
                new Potreba("hlad"),
                new Potreba("hygiena"),
                //new PotrebaSocialnyKontakt(),
                //new Potreba("zabava"),
                new Potreba("wc")
            };
            System.Timers.Timer timer = new System.Timers.Timer(5000); // 5000 milliseconds = 5 seconds

            // Hook up the Elapsed event for the timer
            timer.Elapsed += OnTimedEvent;

            // Set the timer to auto-reset (repeats) after each interval
            timer.AutoReset = true;

            // Start the timer
            timer.Enabled = true;

        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            
            foreach (IStavPotreby potreba in potreby)
            {
                potreba.Zniz(5);
            }
           }
        public Miestnost GetAktualnaMiestnost()
        {
            return this.aktualnaMiestnost;
        }
        public void SetAktualnaMiestnost(Miestnost miestnostik)
        {
            aktualnaMiestnost = miestnostik;
        }


        public void PouziPredmet(string nazov)
        {
            IPredmet predmet = this.aktualnaMiestnost.GetPredmet(nazov);
            predmet.PouziSa(this);
        }

        public IStavPotreby GetPotreba(string nazov)
        {
            foreach (IStavPotreby potreba in this.potreby)
            {
                if (potreba.GetNazov().Equals(nazov))
                {
                    return potreba;
                }
            }
            return null;
        }
       
        public List<IStavPotreby> Potreby { get { return potreby; } }
    }
}
