using GrafikaSemestralna.Hra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Prostredie.Predmety
{
    public class Predmet : IPredmet
    {
        private readonly string nazov;

        public Predmet(string nazvik)
        {
            nazov = nazvik;
        }
        public string GetNazov()
        {
            return nazov;
        }
        public void PouziSa(Zvieratko zvieratko)
        {
            switch (nazov)
            {
                case "wc":
                    zvieratko.GetPotreba("wc").Zvis(100);
                    break;
                case "tv":
                    zvieratko.GetPotreba("zabava").Zvis(50);
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
            }
        }
    }
}
