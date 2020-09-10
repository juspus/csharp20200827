using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200910_VarduIsmetymas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<string> vardaiSarasas = new List<string>();
            int kiekis = rng.Next(5, 15);

            string[] vardai = { "Justas", "Petras", "Greta", "Antanas", "Vardenis", "Pavardenis"};

            for(var i = 0; i< kiekis; i++)
            {
                vardaiSarasas.Add(vardai[rng.Next(0, vardai.Length)]);
            }

            string tekstas = "";
            foreach(var vardas in vardaiSarasas)
            {
                tekstas += (vardas + ", ");
            }
            Console.WriteLine(tekstas);
            Console.Read();
        }
    }
}
