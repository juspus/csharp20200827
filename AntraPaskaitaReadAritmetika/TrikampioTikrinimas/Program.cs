using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrikampioTikrinimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            bool trikampis = false;

            if(a+b <= c)
            {
                trikampis = false;
            }
            else if(b+c<=a)
            {
                trikampis = false;
            }
            else if(c+a<=b)
            {
                trikampis = false;
            }
            else
            {
                trikampis = true;
            }

            if(trikampis)
            {
                Console.WriteLine("trikampis gaunasi");
            }
            else
            {
                Console.WriteLine("trikampis nesigauna");
            }

            Console.ReadLine();
        }
    }
}
