using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirma_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Justas";
            string pavarde = "Puodzius";
            int amzius = 23;
            float ugis = 1.5f;
            double svoris = 5.56846846546846;
            string aukstoji_mokykla = "KTU";

            string akademinesGrKodas = "ERB-6/2";
            int kursas = 4;
            string programosPav = "Robotika";
            int kredituSkaicius = 200;

            string pirmaUzduotis = "Pravesti paskaita";
            string antraUzduotis = "Grizti Namo";
            string treciaUzduotis = "Indaplove";

            

            Console.WriteLine("TODO Programa");
            Console.WriteLine("1. " + pirmaUzduotis);
            Console.Write("2. {0}", antraUzduotis);
            Console.WriteLine("\n3. " + treciaUzduotis);
            
            Console.Write(amzius + "\n" + ugis);

            
            Console.WriteLine("\n\n\n\n"+@"//////////////////////////");
            Console.WriteLine("STUDENTO DUOMENYS");
            Console.WriteLine(vardas + " " + pavarde + " (" + amzius + " m.)");
            Console.WriteLine("Jo ugis yra {0}m., o svoris {1} kg.", ugis, svoris);
            Console.WriteLine("Jis mokosi aukstojoe mokykloje: {0} ({1})", aukstoji_mokykla, programosPav);
            Console.WriteLine("Akademine grupe kuriai priklauso: {0}", akademinesGrKodas);
            Console.WriteLine("Jau yra baiges {0}, kursus, siuo metu mokosi {1} kurse", kursas-1 ,kursas);
            Console.WriteLine("Per studiju laikotarpi atsiskaite uz " + kredituSkaicius +" kreditu.");


            Console.ReadLine();
        }
    }
}
