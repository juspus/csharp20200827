using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201006_EventsMetronomas
{
    class Metronomas
    {
        private TimeSpan Daznis { get; }
        public TimeSpan laikoTarpas { get; set; }
        public event EventHandler<PernestasGarsasEventArgs> SoundEmited;
        public Metronomas(TimeSpan Daznis)
        {
            this.Daznis = Daznis;
        }
        public void Start()
        {
            bool tik = true;
            var laikas = DateTime.Now;
            var ikiKada = DateTime.Now + laikoTarpas;
            OnSoundEmited("tik");
            laikas += Daznis;
            while(DateTime.Now < ikiKada)
            {
                if(laikas < DateTime.Now)
                {
                    tik = !tik;
                    if (tik)
                    {
                        OnSoundEmited("tik");
                    }
                    else
                    {
                        OnSoundEmited("tak");
                    }
                    laikas = DateTime.Now + Daznis;
                }                
            }
        }
        public void OnSoundEmited(string garsas)
        {
            if(SoundEmited != null)
            {
                PernestasGarsasEventArgs arg = new PernestasGarsasEventArgs();
                arg.Garsas = garsas;
                SoundEmited(this, arg);
            }
        }
    }

    public class PernestasGarsasEventArgs : EventArgs
    {
        public string Garsas { get; set; }
    }
}
