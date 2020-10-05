using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20201005_Action
{
    class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void Atimtis(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public static void Pasisveikinti()
        {
            Console.WriteLine("Sveiki");
        }
        public static void Greet()
        {
            Console.WriteLine("Hello");
        }

        static void Main(string[] args)
        {
            Action<int, int> sudetiesVeiksmas = Add;

            sudetiesVeiksmas(5, 8);
            sudetiesVeiksmas += Atimtis;
            Console.WriteLine("--------------------");
            sudetiesVeiksmas(5, 8);
            Console.WriteLine("--------------------");
            sudetiesVeiksmas -= Add;
            sudetiesVeiksmas += Atimtis;
            sudetiesVeiksmas += Atimtis;
            sudetiesVeiksmas += Atimtis;
            sudetiesVeiksmas += Atimtis;
            sudetiesVeiksmas += Add;
            sudetiesVeiksmas += Add;
            sudetiesVeiksmas += Add;
            sudetiesVeiksmas(5, 8);
            //Console.WriteLine(sudetiesVeiksmas.GetInvocationList());
            foreach (var metodai in sudetiesVeiksmas.GetInvocationList())
            {
                Console.WriteLine(metodai.GetMethodInfo());
            }

            //______________________________________________________________
            Action sveikinimuKoncertas = Pasisveikinti;
            sveikinimuKoncertas += Greet;
            sveikinimuKoncertas += Pasisveikinti;
            sveikinimuKoncertas += Greet;
            sveikinimuKoncertas -= Greet;
            sveikinimuKoncertas -= Greet;

            sveikinimuKoncertas();


            Console.Read();
        }
    }
}
