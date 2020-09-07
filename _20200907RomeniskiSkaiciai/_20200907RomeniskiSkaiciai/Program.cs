using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.ReadLine();
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
