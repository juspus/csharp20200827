using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908_MasyvoMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int masyvoDydis = Convert.ToInt32(Ivedimas("Kokio dydzio masyvo norite?"));

            int[] skaiciai = new int[masyvoDydis];
            

            for(var i =0; i<skaiciai.Length; i++)
            {
                skaiciai[i] = Convert.ToInt32(Ivedimas("Masyvo " + (i+1) +" reiksme:"));
            }

            int min = skaiciai[0];
            int max = skaiciai[0];

            for(var i = 0; i< skaiciai.Length; i++)
            {
                if(skaiciai[i]>max)
                {
                    max = skaiciai[i];
                }

                if(skaiciai[i]<min)
                {
                    min = skaiciai[i];
                }
            }

            Console.WriteLine("Min: {0}  Max: {1}",min, max);

            Console.Read();

        }
        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
