using GrafikaSemestralna.Hra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Prostredie.Predmety
{
    public class Postel : IPredmet
    {
        private readonly string nazov;

        public Postel()
        {
            nazov = "postel";
        }

        public string GetNazov()
        {
            return nazov;
        }

        public void PouziSa(Zvieratko zvieratko)
        {
            // Code for method implementation
        }
    }
}
