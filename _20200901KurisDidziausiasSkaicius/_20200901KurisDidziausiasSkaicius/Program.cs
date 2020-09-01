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

            if (a > b && a > c)
            {
                Console.WriteLine("a didziausias");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine("c didziausias");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b didziausias");
            }
            else
            {
                if (a == b)
                {
                    Console.WriteLine("a ir b yra didziausi");
                }
                else if (a == c)
                {
                    Console.WriteLine("a ir c yra didziausi");
                }
                else if (b == c)
                {
                    Console.WriteLine("b ir c yra didziausi");
                }
                else
                {
                    Console.WriteLine("Visi skaiciai lygus");
                }
            }

            Console.ReadLine();
        }
    }
}
