using GrafikaSemestralna.Prostredie.Predmety;
using GrafikaSemestralna.Prostredie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrafikaSemestralna.Hra.Potreby;

namespace GrafikaSemestralna.Hra
{
    public class Zvieratko
    {
        private readonly string meno;
        private Miestnost aktualnaMiestnost;
        private ZijeZvieratko stavZvieratka;
        private readonly List<IStavPotreby> potreby;

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
    }
}
