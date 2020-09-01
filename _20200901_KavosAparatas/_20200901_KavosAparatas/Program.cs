using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200901_KavosAparatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasome pasirinkti:");
            Console.WriteLine("1-Limonadas");
            Console.WriteLine("2-Arbata");
            Console.WriteLine("3-Kakava");
            Console.WriteLine("4-Kava");
            Console.WriteLine("5-Nieko");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch(pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Gaminamas Limonadas");
                    break;
                case 2:
                    Console.WriteLine("Gaminamas arbata");
                    break;
                case 3:
                    Console.WriteLine("Gaminama kakava");
                    break;
                case 4:
                    Console.WriteLine("Gaminama kava");
                    break;
                case 5:
                    Console.WriteLine("Atsaukta");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nera!");
                    break;
            }

            Console.ReadLine();

        }
    }
}
