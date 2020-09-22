using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    class TenisoKamuolys : Kamuolys
    {
        public enum KamuolioTipas
        {
            Lauko = 0,
            Stalo = 1,
            Mokomasis,
            Vaikiškas
        }

        public KamuolioTipas Tipas {get;}

        public TenisoKamuolys(string firma, double radius, Spalva spalva, KamuolioTipas tipas):base(firma, radius, spalva)
        {
            Tipas = tipas;
        }

        protected override void SprogimoGarsas()
        {            
            if(Tipas == KamuolioTipas.Stalo)
            {
                Console.WriteLine("Trakšt");
            }
        }

        public static KamuolioTipas AtsitiktinisTipas(Random rng)
        {
            int rngSk = rng.Next(0, 3);
            if(rngSk == 0)
            {
                return KamuolioTipas.Lauko;
            }
            else if (rngSk == 1)
            {
                return KamuolioTipas.Mokomasis;
            }
            else if (rngSk == 2)
            {
                return KamuolioTipas.Stalo;
            }
            else
            {
                return KamuolioTipas.Vaikiškas;
            }
        }
    }
}
