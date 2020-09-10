using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200910MultidimensinisMasymas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] DuDMasyvas = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int masyvoReiksmiuSuma = 0;
            double vidurkis = 0;
            var sum = 0;

            foreach(var i in DuDMasyvas)
            {
                sum += i;
            }

            for(var i =0; i< DuDMasyvas.GetLength(0); i++)
            {
                for(var j = 0;j<DuDMasyvas.GetLength(1);j++)
                {
                    masyvoReiksmiuSuma += DuDMasyvas[i, j];
                }
            }

            vidurkis = (double)masyvoReiksmiuSuma / DuDMasyvas.Length;

            Console.WriteLine("Suma: " + masyvoReiksmiuSuma);
            Console.WriteLine("Vidurkis: " + vidurkis);
            DuDMasyvas[1, 1] = 684684;


            for (var i = 0; i < DuDMasyvas.GetLength(0); i++)
            {
                string tekstas = "";
                for (var j = 0; j < DuDMasyvas.GetLength(1); j++)
                {
                    tekstas += DuDMasyvas[i, j] + "\t";
                }
                Console.WriteLine(tekstas);
            }

            Console.ReadLine();
        }
    }
}
