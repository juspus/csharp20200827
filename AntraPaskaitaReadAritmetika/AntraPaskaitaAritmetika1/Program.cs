using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraPaskaitaAritmetika1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas skaicius: ");
            var sk1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Antras skaicius: ");
            var sk2 = Convert.ToDouble(Console.ReadLine());

            double sudetis = sk1 + sk2;
            double atimtis = sk1 - sk2;
            double daugyba = sk1 * sk2;
            double dalyba = sk1 / sk2;

            Console.WriteLine(sk1+"+"+sk2 + "=" + sudetis);
            Console.WriteLine(sk1+"-"+sk2+ "=" + (sk1-sk2));
            Console.WriteLine(sk1+"*"+sk2+"=" + daugyba);
            Console.WriteLine("{0}/{1}={2}", sk1, sk2, dalyba);

            Console.ReadLine();
        }
    }
}
