using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200907PasisveikinimasAmziusHobis
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasisveikinimas();
            string a = Ivedimas("Iveskite varda: ");
            int b = Convert.ToInt32(Ivedimas("Iveskite amziu: "));
            string c = Ivedimas("Koks tavo hobis?");

            Atsakymas(a, b, c);
            Console.Read();
        }

        private static void Atsakymas(string vardas, int amzius, string hobis)
        {
            Console.WriteLine("Jusu vardas: {0}, jums metu: {1}, ir megstat: {2}",vardas, amzius, hobis);
        }

        private static void Pasisveikinimas()
        {
            Console.WriteLine("Sveiki!");
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
