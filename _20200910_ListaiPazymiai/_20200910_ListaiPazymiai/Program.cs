using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200910_ListaiPazymiai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();
            string pazymys = "";
            while(true)
            {
                pazymys = Ivedimas("Iveskite pazymi:");
                if (pazymys == "ne")
                {
                    break;
                }
                else
                {
                    pazymiai.Add(Convert.ToInt32(pazymys));
                }                
            }

            Console.WriteLine("Average: {0}", pazymiai.Average());
            Console.WriteLine("Min: {0}", pazymiai.Min());
            Console.WriteLine("Max: {0}", pazymiai.Max());
            Console.WriteLine("First: {0}", pazymiai[0]);
            Console.WriteLine("Last: {0}", pazymiai.Last());

            Console.Read();
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
