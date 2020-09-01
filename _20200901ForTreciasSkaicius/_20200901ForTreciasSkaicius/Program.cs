using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20200901ForTreciasSkaicius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirma dalis");
            int sk;
            for(sk = 0; sk<20; sk++)
            {
                if (sk % 3 == 0)
                {
                    Console.WriteLine(sk);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Antra dalis");

            for(int i=0; i<20; i+=3)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
