using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200901_SwitchPvz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu c:");
            double c = Convert.ToDouble(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.WriteLine("Suma: {0}", a+b+c);
                    break;
                case 2:
                    Console.WriteLine("Skirtumas: {0}", a-c);
                    break;
                case 3:
                    Console.WriteLine("Sandauga: {0}", b*c);
                    break;
            }

            Console.ReadLine();
        }
    }
}
