using GrafikaSemestralna.Hra.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Hra.Potreby
{
    public class Zivot : Potreba
    {
        private ZijeZvieratko stav;

        public Zivot() : base("zivot")
        {
            stav = ZijeZvieratko.ZIJE;
        }

        new public void Zvis(int pocet)
        {
            if (this.stav == ZijeZvieratko.ZIJE)
            {
                base.Zvis(pocet);
            }
        }

        new public void Zniz(int pocet)
        {
            base.Zniz(pocet);
            if (GetAktualnePercent() == 0)
            {
                stav = ZijeZvieratko.MRTVE;
                
            }
        }

        public void Stav()
        {
            try
            {
                if (stav == ZijeZvieratko.MRTVE)
                {
                    throw new HraKonciPrehraException("Zvieratku dosiel zivot");
                }
            }
            catch (HraKonciPrehraException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
