using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Hra.Exceptions
{
    public class HraKonciPrehraException : Exception
    {
        public HraKonciPrehraException(string sprava) : base(sprava)
        {

        }
    }
}
