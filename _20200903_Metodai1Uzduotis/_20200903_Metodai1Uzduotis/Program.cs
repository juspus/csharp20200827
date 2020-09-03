using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200903_Metodai1Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Tekstas();
            StaticTekstas();
            Console.ReadLine();
        }

        private void Tekstas()
        {
            Console.WriteLine("Isvestas tekstas!");
        }

        private static void StaticTekstas()
        {
            Console.WriteLine("Static isvestas tekstas!");
        }
    }
}
