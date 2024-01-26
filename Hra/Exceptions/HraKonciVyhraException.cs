using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Hra.Exceptions
{
    public class HraKonciVyhraException : Exception
    {
        public HraKonciVyhraException(string sprava) : base(sprava)
        {

        }
    }
}
