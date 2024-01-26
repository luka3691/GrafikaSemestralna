using GrafikaSemestralna.Prostredie.Predmety;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Prostredie
{
   
    public class Prostredia
    {
        private readonly Miestnost startovaciaMiestnost;

        public Prostredia()
        {
            Miestnost vstupnaHala = new Miestnost("vstupnaHala");
            this.startovaciaMiestnost = vstupnaHala;

            Miestnost praca = new Miestnost("praca");

            Miestnost obyvacka = new Miestnost("obyvacka");

            Miestnost jedalen = new Miestnost("jedalen");

            Miestnost kuchyna = new Miestnost("kuchyna");

            Miestnost spalna = new Miestnost("spalna");

            Miestnost balkon = new Miestnost("balkon");

            Miestnost podkrovie = new Miestnost("podkrovie");

            Miestnost kupelna = new Miestnost("kupelna");

            vstupnaHala.NastavVychod("juh", praca);
            vstupnaHala.NastavVychod("sever", obyvacka);

            praca.NastavVychod("sever", vstupnaHala);

            obyvacka.NastavVychod("sever", spalna);
            obyvacka.NastavVychod("juh", vstupnaHala);
            obyvacka.NastavVychod("vychod", jedalen);
            obyvacka.NastavPredmet(new Predmet("tv"));

            jedalen.NastavVychod("zapad", obyvacka);
            jedalen.NastavVychod("vychod", kuchyna);

            kuchyna.NastavVychod("zapad", jedalen);
            kuchyna.NastavPredmet(new Predmet("chladnicka"));

            spalna.NastavVychod("juh", obyvacka);
            spalna.NastavVychod("sever", podkrovie);
            spalna.NastavVychod("zapad", balkon);
            spalna.NastavPredmet(new Postel());


            podkrovie.NastavVychod("juh", spalna);

            balkon.NastavVychod("vychod", spalna);
            balkon.NastavPredmet(new Vzduch());

            kupelna.NastavPredmet(new Predmet("wc"));
            kupelna.NastavPredmet(new Predmet("sprcha"));

        }

        public Miestnost GetStartovaciaMiestnost()
        {
            return this.startovaciaMiestnost;
        }
    }
}
