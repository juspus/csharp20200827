using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200915_KortuKalade
{
    class Korta
    {
        public string Zenklas { get; }
        public string Verte { get; }
        public string Spalva { get; }

        public Korta(string zenklas, int verte)
        {
            if(verte == 11)
            {
                Verte = "J";
            }
            else if(verte == 12)
            {
                Verte = "Q";
            }
            else if(verte == 0)
            {
                Verte = "K";
            }
            else if (verte == 1)
            {
                Verte = "A";
            }            
            else
            {
                Verte = verte.ToString();
            }

            Zenklas = zenklas;

            if(Zenklas == "S"|| Zenklas == "B")
            {
                Spalva = "Raudona";
            }
            else
            {
                Spalva = "Juoda";
            }
        }

        public void Info()
        {
            Console.WriteLine("{0}{1}", Zenklas, Verte);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<Korta> kalade = new List<Korta>();
            string[] zenklai = new string[] { "S", "B", "K", "P" };

            while(kalade.Count() < 52)
            {
                var generuojamas = rng.Next(0, 52);
                int znklonr = generuojamas / 13;
                
                int verte = generuojamas % 13;

                Korta naujaKorta = new Korta(zenklai[znklonr], verte);

                if(!ArEgzistuoja(naujaKorta, kalade))
                {
                    kalade.Add(naujaKorta);
                }
            }

            foreach(Korta k in kalade)
            {
                k.Info();
            }
            Console.Read();
        }

        public static bool ArEgzistuoja(Korta korta, List<Korta> kalade)
        {
            foreach(var card in kalade)
            {
                if(korta.Verte == card.Verte && korta.Zenklas == card.Zenklas)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
