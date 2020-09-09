using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908_MasyvaiPirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = {15, 684, 65, 35, 84, 89, 56 ,65 ,2 ,6};
            string[] teksto = new string[4];
            teksto[0] = "pirma eilute";
            teksto[1] = "antra eilute";
            teksto[2] = "trecia eilute";
            teksto[3] = "ketvirta";

            Console.WriteLine(skaiciai[0]);
            Console.WriteLine(skaiciai[skaiciai.Length-1]);
            Console.WriteLine(skaiciai.Length);
            Console.WriteLine(teksto[0]);
            Console.WriteLine(teksto[teksto.Length-1]);
            Console.WriteLine(teksto.Length);
            Console.ReadKey();
        }
    }
}
