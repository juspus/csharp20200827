using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturos = { -5, 10, 23, 5, 0, -8 };

            int min = temperaturos[0];
            int max = temperaturos[0];
            int suma = 0;
            double vidurkis = 0;
            foreach(var temp in temperaturos)
            {
                if(min > temp)
                {
                    min = temp;
                }

                if(max < temp)
                {
                    max = temp;
                }

                vidurkis += temp;
            }

            vidurkis /= temperaturos.Length;

            foreach(var temp in temperaturos)
            {
                if(temp<vidurkis)
                {
                    suma += temp;
                }
            }

            Console.WriteLine("Min: {0} Max: {1} Vidurkis {2} Suma: {3}", min, max, vidurkis, suma);
            Console.Read();

        }
    }
}
