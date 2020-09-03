using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200903_Zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zaidziam! 1-3000  M/L/D/R");
            string ats = "";
            int skaicius = 1500;
            int pokytis = skaicius / 2;
            while(true)
            {                
                Console.WriteLine("Ar jusu skaicius yra {0}?", skaicius);
                Console.WriteLine();
                ats = Console.ReadLine();
                
                if(ats.ToLower() == "m")
                {
                    skaicius += pokytis;
                }
                else if(ats.ToLower() == "l")
                {
                    skaicius -= pokytis;
                }
                else if(ats.ToLower() == "d")
                {
                    Console.WriteLine("Atspejau!");
                    break;
                }
                else if(ats.ToLower() == "r")
                {
                    skaicius = 1500;
                    pokytis = skaicius / 2;
                }
                else
                {
                    Console.WriteLine("Klaidingai ivestas atsakymas! Bandykite dar karta!");
                    continue;
                }

                pokytis = pokytis / 2;
                if(pokytis<1)
                {
                    pokytis = 1;
                }
            }
            Console.ReadLine();
        }
    }
}
