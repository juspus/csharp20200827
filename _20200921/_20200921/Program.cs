using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _20200921
{
    class Program
    {
        private static Random rng;
        static void Main(string[] args)
        {
            rng = new Random();
            int kamuoliuKiekis = rng.Next(20, 100);
            List<Kamuolys> pintine = UzpildauRusiKamuoliais(kamuoliuKiekis);

            foreach(Kamuolys ball in pintine)
            {
                ball.Info();
                while (!ball.Sproges)
                {
                    ball.Mesti();                    
                }
                ball.Info();
                Console.WriteLine("______________________________");
            }

            Console.Read();
        }

        public static List<Kamuolys> UzpildauRusiKamuoliais(int kiekis)
        {
            List<Kamuolys> rusys = new List<Kamuolys>();
            for(var i = 0; i<kiekis; i++)
            {
                rusys.Add(KamuolioGeneravimas());
            }
            return rusys;
        }

        public static string FirmosPavadinimoParinkimas(string[] firmos)
        {            
            return firmos[rng.Next(0, firmos.Length)];
        }

        public static Kamuolys KamuolioGeneravimas()
        {
            int rngSk = rng.Next(0, 3);

            string[] firmos = { "Maxima", "MBA", "UAB Perkunas", "Snaige", "Kamuoliu Gamintojas" };
            string firmosPav = FirmosPavadinimoParinkimas(firmos);
            bool tipas = rng.NextDouble() < 0.5;
            if (rngSk == 0)
            {
                return new KrepsinioKamuolys(firmosPav,rng.Next(20,30), tipas);
            }
            else if(rngSk == 1)
            {
                return new TinklinioKamuolys(firmosPav, rng.Next(20, 30), tipas, new Spalva(rng));
            }
            else if(rngSk == 2)
            {
                return new TenisoKamuolys(firmosPav, rng.Next(5, 15), new Spalva(rng), TenisoKamuolys.AtsitiktinisTipas(rng));
            }
            else
            {
                return null;
            }
        }

    }
}
