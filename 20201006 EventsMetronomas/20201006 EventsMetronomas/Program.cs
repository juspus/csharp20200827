using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201006_EventsMetronomas
{
    class Program
    {
        static void Main(string[] args)
        {
            Metronomas metras = new Metronomas(TimeSpan.FromSeconds(2));
            metras.laikoTarpas = TimeSpan.FromSeconds(15);
            metras.SoundEmited += Muzikantas.GirdziuMetronomaIrPasakauGarsa;
            metras.SoundEmited += Muzikantas.SugrojuGarsa;
            metras.Start();
        }
    }
}
