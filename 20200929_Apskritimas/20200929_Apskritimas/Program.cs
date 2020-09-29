using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_Apskritimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Apskritimas apskritimas = new Apskritimas(new Taskas(5, 8), 24.65);
            var kiekis = rng.Next(100,200);
            Dictionary<Taskas, bool> taskuSarasas = new Dictionary<Taskas, bool>();
            for (var i =0; i<kiekis; i++)
            {
                Taskas pt = new Taskas(rng.Next(-50, 50), rng.Next(-50, 50));
                taskuSarasas.Add(pt, apskritimas.ArTaskasApskritimoViduje(pt));
            }
           

            foreach(var i in taskuSarasas)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
