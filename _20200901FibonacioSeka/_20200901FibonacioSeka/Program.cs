using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200901FibonacioSeka
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk1 = 0;
            int sk2 = 1;
            int sk3 = 0;

            Console.WriteLine("Iveskite kieki: ");
            int kiekis = Convert.ToInt32(Console.ReadLine());
            //Isvedami pirmieji 2 skaiciai
            Console.WriteLine();
            Console.WriteLine(sk1);
            Console.WriteLine(sk2);
            //Sukamas ciklas tiek kartu -2 kiek uzduota
            for(var i = 2; i<kiekis; i++)
            {
                sk3 = sk1 + sk2;
                Console.WriteLine(sk3);
                sk1 = sk2;
                sk2 = sk3;
            }
            Console.ReadLine();

        }
    }
}
