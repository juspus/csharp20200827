using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908_CountryLeader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] leader = { "Trump", "Nauseda", "Putin" };
            string[] country = { "USA", "LT", "RUS" };
            var paieskosTekstas = Ivedimas("Iveskite paieska: ");

            if(Paieska(paieskosTekstas, leader) != -1)
            {
                Console.WriteLine(country[Paieska(paieskosTekstas, leader)]);
            }
            else if(Paieska(paieskosTekstas, country) != -1)
            {
                Console.WriteLine(leader[Paieska(paieskosTekstas, country)]);
            }
            else
            {
                Console.WriteLine("Tokios ivesties nera.");
            }
            Console.ReadKey();

        }

        private static int Paieska(string paieskosTekstas, string[] masyvas)
        {
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (paieskosTekstas.ToLower() == masyvas[i].ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
