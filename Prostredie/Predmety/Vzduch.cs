using GrafikaSemestralna.Hra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Prostredie.Predmety
{
    public class Vzduch : IPredmet
    {
        private readonly string nazov;
        private Stopky stopky;
        private bool vstupeny;

        public Vzduch()
        {
            this.nazov = "postel";
            this.stopky = new Stopky();
            this.vstupeny = false;
        }

        public string GetNazov()
        {
            return this.nazov;
        }

       

        public void PouziSa(Zvieratko zvieratko)
        {
            if (zvieratko.GetAktualnaMiestnost().GetPopis().Equals("balkon") && !this.vstupeny)
            {
                this.vstupeny = true;
                this.stopky.start();
            }
            else if (!zvieratko.GetAktualnaMiestnost().GetPopis().Equals("balkon") && this.vstupeny)
            {
                this.stopky.stop();
                zvieratko.GetPotreba("zivot").Zvis(this.stopky.getTrvanie() / 2);
                this.stopky.reset();
                this.vstupeny = false;
            }
        }

        
    }
}
