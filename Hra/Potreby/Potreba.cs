using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Hra.Potreby
{
    public class Potreba : IStavPotreby
    {
        private int percent;
        private readonly string nazov;

        public Potreba(string nazvik)
        {
            this.percent = 100;
            this.nazov = nazvik;
        }

        public void Zvis(int pocet)
        {
            this.percent = this.percent + pocet;
            if (this.percent > 100)
            {
                this.percent = 100;
            }
        }

        public void Zniz(int pocet)
        {
            this.percent = this.percent - pocet;
            if (this.percent < 0)
            {
                this.percent = 0;
            }
        }

        public int GetAktualnePercent()
        {
            return this.percent;
        }

        public string GetNazov()
        {
            return this.nazov;
        }
    }
}
