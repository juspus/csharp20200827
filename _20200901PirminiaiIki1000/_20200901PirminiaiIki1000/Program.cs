using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200901PirminiaiIki1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 5;
            for(int i =2; i< 1000; i++)
            {
                if(i%2 != 0 && i%3 !=0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Suma: {0}", suma);
            Console.ReadLine();
        }
    }
}
