using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    class BoulingoKamuolys:Kamuolys
    {
        private double _Svoris { get; }
        public int Dydis { get; }
        private DateTime _SukurimoData { get; }
        private TimeSpan _GaliojimoLaikas { get; }

        public BoulingoKamuolys(string firma, double spindulys, double svoris, DateTime sukurimas, TimeSpan galiojimas, Spalva spl, int dydis = 5) :base(firma, spindulys, spl)
        {
            _Svoris = svoris;
            _SukurimoData = sukurimas;
            _GaliojimoLaikas = galiojimas;
            Dydis = dydis;
        }

        public override void Mesti()
        {
            if (!Sproges)
            {
                MetimuSk++;
            }
           

            if(DateTime.Now>_SukurimoData+_GaliojimoLaikas)
            {
                Sprogdinti();
            }
        }

        protected override void SprogimoGarsas()
        {
            Console.WriteLine("Crack");
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Svoris: {0}, Dydis: {1}", _Svoris, Dydis);
        }
    }
}
