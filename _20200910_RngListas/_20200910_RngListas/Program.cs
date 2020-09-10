using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200910_RngListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> rngSarasas = new List<int>();
            
            int kiekis = rng.Next(0, 1000);

            for(int i = 0; i<kiekis; i++)
            {
                rngSarasas.Add(rng.Next(-1000, 1000));
                Console.WriteLine("Naujos average: {0}", rngSarasas.Average());
            }

            int nelyginiuSuma = 0;
            int nelyginiuKiekis = 0;
            foreach(var skaicius in rngSarasas)
            {
                Console.WriteLine(skaicius);
                if(skaicius%2!=0)
                {
                    nelyginiuKiekis++;
                    nelyginiuSuma += skaicius;
                }
            }

            Console.WriteLine("Suma: {0}", rngSarasas.Sum());
            Console.WriteLine("Average: {0}", rngSarasas.Average());
            Console.WriteLine("Min: {0}", rngSarasas.Min());
            Console.WriteLine("Max: {0}", rngSarasas.Max());
            Console.WriteLine("First: {0}", rngSarasas.First());
            Console.WriteLine("Last: {0}", rngSarasas.Last());
            Console.WriteLine("Kiekis {0}", rngSarasas.Count());
            Console.WriteLine("Nelyginiu suma: {0}, nelyginiu kiekis: {1}", nelyginiuSuma, nelyginiuKiekis);


            Console.Read();
        }
    }
}
