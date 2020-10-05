using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _20201005_DelegataiZmones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> duomenys = File.ReadAllLines("zmones.txt").ToList();

            foreach(var eilute in duomenys)
            {
                Zmogus zmogus = new Zmogus(eilute, AmziausTikrinimas.KokiaGrupe);
                Console.WriteLine("{0}, {1}, {2}", zmogus.Vardas, zmogus.Amzius, zmogus.Grupe.ToString());
            }

            Console.Read();
        }
    }
}
