using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200901_SudetingesniIfaiUzduotis2
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

            if(a>b && a<100)
            {
                Console.WriteLine("Pirma salyga");
            }

            if(b>a && b>0)
            {
                Console.WriteLine("Antra salyga");
            }

            if(a>b && a>c || a>0)
            {
                Console.WriteLine("Trecia salyga");
            }

            if((c<= 10 && c>=5) || c>a || c>b)
            {
                Console.WriteLine("Ketvirta salyga");
            }

            Console.ReadLine();
        }
    }
}
