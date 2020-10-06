using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201006_EventsMetronomas
{
    static class Muzikantas
    {
        public static void GirdziuMetronomaIrPasakauGarsa(object sender, PernestasGarsasEventArgs e)
        {
            Console.WriteLine(e.Garsas);
        }

        public static void SugrojuGarsa(object sender, PernestasGarsasEventArgs e)
        {
            if(e.Garsas == "tik")
            {
                Console.Beep(1000, 50);
            }
            else
            {
                Console.Beep(500, 50);
            }
            
        }
    }
}
