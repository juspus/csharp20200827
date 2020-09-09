using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20200907RomeniskiSkaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            int IvestasSkaicius = Convert.ToInt32(Ivedimas("Iveskite konvertuojama skaiciu:"));
            RomanNumerals.RomanNumeral p = new RomanNumerals.RomanNumeral(IvestasSkaicius);
            Console.WriteLine(p.ToString());

            //_____________________________________//

            int tukstanciai = IvestasSkaicius / 1000;
            int tarpSkaicius = IvestasSkaicius % 1000;
            int simtai = tarpSkaicius / 100;
            tarpSkaicius = tarpSkaicius % 100;
            int desimtys = tarpSkaicius / 10;
            int vienetai = tarpSkaicius % 10;

            string roman = "";
            roman += Roman(tukstanciai, "M", "M", "M");
            roman += Roman(simtai, "C", "D", "M");
            roman += Roman(desimtys, "X", "L", "C");
            roman += Roman(vienetai, "I", "V", "X");

            Console.WriteLine(roman);
            Console.ReadLine();
        }

        public static string Tukstanciai(int sk)
        {
            string atsakymas = "";
            for(int i = 0; i<sk; i++)
            {
                atsakymas += "M";
            }
            return atsakymas;
        }

        public static string Roman(int sk, string vnt, string pnk, string des)
        {
            string atsakymas = "";
            if(sk<4)
            {
                for (int i = 0; i < sk; i++)
                {
                    atsakymas += vnt;
                }
            }
            else if (sk == 4)
            {
                atsakymas += vnt+pnk;
            }
            else if(sk == 9)
            {
                atsakymas += vnt+des;
            }
            else
            {
                atsakymas += pnk;
                for (int i = 0; i < sk-5; i++)
                {
                    atsakymas += vnt;
                }
            }
            
            return atsakymas;
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
