using GrafikaSemestralna.Prostredie.Predmety;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Prostredie
{
    public class Miestnost
    {
        private readonly string popisMiestnosti;
        private Dictionary<string, Miestnost> vychody;
        private Dictionary<string, IPredmet> predmety;

        public Miestnost(string popis)
        {
            this.popisMiestnosti = popis;
            this.vychody = new Dictionary<string, Miestnost>();
            this.predmety = new Dictionary<string, IPredmet>();
        }

        public void NastavVychod(string smer, Miestnost ciel)
        {
            this.vychody.Add(smer, ciel);
        }

        public string GetPopis()
        {
            return this.popisMiestnosti;
        }

        public void NastavPredmet(IPredmet predmet)
        {
            this.predmety.Add(predmet.GetNazov(), predmet);
        }

        public IPredmet GetPredmet(string nazov)
        {
            return this.predmety[nazov];
        }
        public Dictionary<string, Miestnost> Vychody { get { return vychody; } }
        public Dictionary<string, IPredmet> Predmety { get { return predmety; } }
    }
}
