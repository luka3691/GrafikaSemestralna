using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Hra.Potreby
{
    public interface IStavPotreby
    {
        void Zvis(int pocet);
        void Zniz(int pocet);
        int GetAktualnePercent();
        string GetNazov();
    }
}
