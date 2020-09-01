using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200901For7Sandauga
{
    class Program
    {
        static void Main(string[] args)
        {
            int rez = 1;
            for(int i = 1; i<100; i++)
            {
                if(i%7==0)
                {
                    rez *= i;
                }
            }
            Console.WriteLine("Sandauga: {0}", rez);
            Console.ReadLine();
        }
    }
}
