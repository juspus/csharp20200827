using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200915_Zoo
{   
    class Vabzdys:Bestuburiai
    {
        public bool Skraido { get; set; }
        public Vabzdys(int id, string vardas, string rusis, string spalva, int kojusk, string lytis, TimeSpan miegoTrukme, int akiuSk, int narvoNr, DateTime maitLaikas, DateTime gimtadienis, TimeSpan sotumoLaikas) : base(id, vardas, rusis, spalva, kojusk, lytis, miegoTrukme, akiuSk, narvoNr, maitLaikas, gimtadienis, sotumoLaikas)
        {
            
        }

    }
}
