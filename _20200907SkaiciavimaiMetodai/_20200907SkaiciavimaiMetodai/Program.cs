using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20200907SkaiciavimaiMetodai
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Ivedimas("Pirmas skaicius: "));
            var b = Convert.ToInt32(Ivedimas("Antras skaicius: "));
            Isvedimas(a, b);
            Console.Read();
        }

        private static int Sudetis(int sk1, int sk2)
        {
            var suma = sk1 + sk2;
            return suma;
        }

        private static int Atimtis(int sk1, int sk2)
        {
            return sk1 - sk2;
        }
        private static int Daugyba(int sk1, int sk2)
        {
            return sk1 * sk2;
        }
        private static double Dalyba(double sk1, double sk2)
        {
            return sk1 / sk2;
        }

        private static string Operacija(int a, int b, string veiksmas)
        {
            string tekstas = a.ToString();
            double atsakymas = 0;
            if(veiksmas == "+")
            {
                tekstas += "+";
                atsakymas = Sudetis(a, b);
            }
            else if(veiksmas == "-")
            {
                tekstas += "-";
                atsakymas = Atimtis(a, b);
            }
            else if(veiksmas == "*")
            {
                tekstas += "*";
                atsakymas = Daugyba(a, b);
            }
            else if (veiksmas == "/")
            {
                tekstas += "/";
                atsakymas = Dalyba(a, b);
            }
            else
            {
                return "nera tokio veiksmo";
            }
            tekstas += b + "="+atsakymas;
            return tekstas;
        }

        private static void Isvedimas(int skaicius1, int skaicius2)
        {
            Console.WriteLine(Operacija(skaicius1, skaicius2, "+"));
            Console.WriteLine(Operacija(skaicius1, skaicius2, "-"));
            Console.WriteLine(Operacija(skaicius1, skaicius2, "*"));
            Console.WriteLine(Operacija(skaicius1, skaicius2, "/"));
            Console.WriteLine(Operacija(skaicius1, skaicius2, "["));
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }

    }
}
