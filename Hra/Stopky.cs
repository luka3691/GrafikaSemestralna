using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaSemestralna.Hra
{
    public class Stopky
    {
        private DateTime startTime;
        private DateTime endTime;
        private TimeSpan trvanie;
        private bool bezi = false;

        public void start()
        {
            if (this.bezi)
            {
                throw new Exception("Stopwatch is already running.");
            }
            this.bezi = true;
            this.startTime = DateTime.Now;
        }

        public void stop()
        {
            this.endTime = DateTime.Now;
            if (!this.bezi)
            {
                throw new Exception("Stopwatch has not been started yet");
            }
            this.bezi = false;
            TimeSpan result = this.endTime - this.startTime;
            if (this.trvanie == null)
            {
                this.trvanie = result;
            }
            else
            {
                this.trvanie = this.trvanie.Add(result);
            }

        }

        public int getTrvanie()
        {
            return (int)this.trvanie.TotalSeconds;
        }

        public void reset()
        {
            if (this.bezi)
            {
                this.stop();
            }
            this.trvanie = TimeSpan.Zero;
        }
    }
}
