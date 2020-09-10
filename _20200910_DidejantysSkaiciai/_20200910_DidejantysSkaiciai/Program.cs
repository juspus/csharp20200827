using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200910_DidejantysSkaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivestis = Convert.ToInt32(Ivedimas("Iveskite skaiciu: "));
            int skaicius = 1;
            int skaitliukas = 0;

            while(skaicius<ivestis)
            {
                skaicius *= 2;
                skaitliukas++;
            }

            int[] didejantysSk = new int[skaitliukas];
            didejantysSk[0] = 1;

            for (int i = 1; i<didejantysSk.Length; i++)
            {                
                didejantysSk[i] = didejantysSk[i - 1] * 2;
            }


            //Is priesingos puses
            //didejantysSk = new int[skaitliukas];
            //didejantysSk[didejantysSk.Length - 1] = 1;

            //for (int i = didejantysSk.Length-2; i >= 0; i--)
            //{
            //    didejantysSk[i] = didejantysSk[i + 1] * 2;
            //}

            foreach (var sk in didejantysSk)
            {
                Console.WriteLine(sk);
            }

            Console.ReadLine();
        }

        private static string Ivedimas(string ivedimoZinute)
        {
            Console.WriteLine(ivedimoZinute);
            string ats = Console.ReadLine();
            return ats;
        }
    }
}
