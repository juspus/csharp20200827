using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu a:");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu b:");
            var b = Convert.ToDouble(Console.ReadLine());

            if(a>b)
            {
                Console.WriteLine("{0} daugiau uz {1}", a,b);
            }

            if (a < b)
            {
                Console.WriteLine("{0} maziau uz {1}", a, b);
            }

            if (a == b)
            {
                Console.WriteLine("{0} lygu {1}", a, b);
            }

            //Lyginis skaicius

            if(a % 2 == 0)
            {
                Console.WriteLine( "{0} yra lyginis skaicius", a);
            }

            //Studento amzius

            Console.WriteLine("Iveskite skaiciu studento amziu:");
            var amzius = Convert.ToDouble(Console.ReadLine());

            if(amzius > a)
            {
                Console.WriteLine("studento amzius ({0}) yra daugiau nei pirmas skaicius {1}", amzius, a);
            }
            else if (amzius > b)
            {
                Console.WriteLine("studento amzius ({0}) yra daugiau nei antras skaicius {1}", amzius, b);
            }
            else
            {
                Console.WriteLine("studento amzius ({0}) nera daugiau nei kazkuris is skaiciu ({1} arba {2})", amzius,a, b);
            }


            Console.ReadLine();
        }
    }
}
