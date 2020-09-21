using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    class KrepsinioKamuolys:Kamuolys
    {
        public bool Lauko { get; }
        public KrepsinioKamuolys(string firma, double radius, bool lauko):base(firma, radius, new Spalva(252, 107, 3, 100))
        {            
            Lauko = lauko;
        }

        protected override void Sprogdinti()
        {
            base.Sprogdinti();
            Console.WriteLine("Pokst");
        }
    }
}
