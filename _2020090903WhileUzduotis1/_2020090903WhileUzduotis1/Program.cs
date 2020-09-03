using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020090903WhileUzduotis1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            Console.WriteLine();

            while(sk>0)
            {
                if(sk%2==0)
                {
                    suma += sk;
                }

                Console.WriteLine(sk--);
            }

            Console.WriteLine("Suma: " +suma);
            Console.ReadLine();
        }
    }
}
