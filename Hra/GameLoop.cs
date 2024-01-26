using GrafikaSemestralna.Hra.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Hra
{
    public class GameLoop
    {
        private StavHry status;
        private Stopky stopkyCelaHra;

        public GameLoop(Stopky stopky1)
        {
            this.status = StavHry.STOJI;
            this.stopkyCelaHra = stopky1;
        }

        public void spusti()
        {
            this.status = StavHry.BEZI;
            this.stopkyCelaHra.start();
            long poslednyCas = DateTime.Now.Ticks;
            int obnovovaciaFrekvencia = 1;
            double ns = 1000000000 / obnovovaciaFrekvencia;
            while (true)
            {
                long teraz = DateTime.Now.Ticks;
                long dlzkaTrvanaia = teraz - poslednyCas;
                poslednyCas = teraz;
            }
        }

        public void stop()
        {
            this.status = StavHry.STOJI;
            this.stopkyCelaHra.stop();
            if (this.stopkyCelaHra.getTrvanie() > 600)
            {
                throw new HraKonciVyhraException("Dozil si sa uspesne svojho konca");
            }
        }
    }
}
