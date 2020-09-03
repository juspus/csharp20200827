using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200903_Svarstykles
{
    class Program
    {
        static void Main(string[] args)
        {
            int kamuoliukas1 = 1;            
            int kamuoliukas2 = 1;
            int kamuoliukas3 = 1;
            int kamuoliukas4 = 1;
            int kamuoliukas5 = 0;
            int kamuoliukas6 = 1;
            int kamuoliukas7 = 1;
            int kamuoliukas8 = 1;
            if (kamuoliukas1+ kamuoliukas2+kamuoliukas3 > kamuoliukas4+kamuoliukas5+kamuoliukas6)
            {
                if(kamuoliukas4>kamuoliukas5)
                {
                    Console.WriteLine("5");
                }
                else if(kamuoliukas4 == kamuoliukas5)
                {
                    Console.WriteLine("6");
                }
                else
                {
                    Console.WriteLine("4");
                }
            }
            else if(kamuoliukas1+kamuoliukas2+kamuoliukas3 == kamuoliukas4+kamuoliukas5+kamuoliukas6)
            {
                if(kamuoliukas7>kamuoliukas8)
                {
                    Console.WriteLine("8");
                }
                else
                {
                    Console.WriteLine("7");
                }
            }
            else
            {
                if (kamuoliukas1 > kamuoliukas2)
                {
                    Console.WriteLine("2");
                }
                else if (kamuoliukas1 == kamuoliukas2)
                {
                    Console.WriteLine("3");
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
            Console.ReadLine();
        }
    }
}
