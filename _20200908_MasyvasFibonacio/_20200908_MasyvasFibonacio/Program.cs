using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908_MasyvasFibonacio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacio = new int[10];

            fibonacio[0] = 1;
            fibonacio[1] = 1;

            for(var i =2; i<fibonacio.Length;i++)
            {
                fibonacio[i] = fibonacio[i - 2] + fibonacio[i - 1];
            }

            foreach(var i in fibonacio)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
