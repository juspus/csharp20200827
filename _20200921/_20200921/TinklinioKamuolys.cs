using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    class TinklinioKamuolys : Kamuolys
    {
        public bool Papludimio { get; }

        public TinklinioKamuolys(string firma, double radius, bool papludimio, Spalva spalva) : base(firma, radius, spalva)
        {
            Papludimio = papludimio;
        }

        protected override void SprogimoGarsas()
        {
            base.SprogimoGarsas();
            Console.WriteLine("Pop");
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine(Papludimio ? "Papludimio" : "Vidaus");
        }
    }
}
