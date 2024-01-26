using GrafikaSemestralna.Hra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Prostredie.Predmety
{
    public interface IPredmet
    {
        string GetNazov();
        void PouziSa(Zvieratko zvieratko);
       
    }
}
