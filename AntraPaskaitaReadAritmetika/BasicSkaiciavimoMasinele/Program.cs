using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSkaiciavimoMasinele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite veiksmo operatoriu: ");
            string operatorius = Console.ReadLine();
            Console.WriteLine("Iveskite skaiciu b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if(operatorius == "+")
            {
                Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            }
            else if(operatorius == "-")
            {
                Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            }
            else if (operatorius == "*")
            {
                Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            }
            else if (operatorius == "/")
            {
                Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            }
            else
            {
                Console.WriteLine("Klaidingas veiksmo operatorius!");
            }


            Console.ReadLine();

        }
    }
}
