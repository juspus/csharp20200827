using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraPaskaitaReadAritmetika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pirma uzduotis
            Console.WriteLine("Iveskite kazka");
            var tekstas = Console.ReadLine();
            Console.WriteLine("Ivesta eilute: ");
            Console.WriteLine(tekstas);
            Console.ReadLine();

            //Antra uzduotis
            Console.WriteLine("Iveskite varda: ");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pirma megstamiausios spalvos raide: ");
            char spalvosRaide = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Iveskite pirma skaiciu:");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vardas: " + vardas + " Raide: " + spalvosRaide + " Skaicius 1: " + skaicius1 + " Skaicius 2: " + skaicius2);
            Console.ReadLine();

            var liekana = skaicius1 % skaicius2;

            Console.WriteLine(liekana);
            Console.ReadLine();
        }
    }
}
