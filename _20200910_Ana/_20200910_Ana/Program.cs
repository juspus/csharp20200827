using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdavinys__1_balui
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            int atsakymas = 0;

            for (int i = skaicius; i >0; i--)
            {
                if (SkaiciuAtrankosMetodas(i))
                {                    
                    Console.WriteLine("skaicius {0} yra taisingas", i);
                    break;
                }
            }
            Console.ReadLine();
        }

        private static bool SkaiciuAtrankosMetodas(int sk)
        {
            int vnt = sk % 10;//iskiriam paskutini skaiciu.
            int dsmt = sk / 10 % 10;//iskiriam pries paskutini skaiciu.

            if (vnt >= dsmt) //vienetas butinai turi buti didesnis.
            {
                sk /= 10;//pasalinam paskutini skaiciu.
                if (sk >= 10)
                {
                    return SkaiciuAtrankosMetodas(sk);//jeigu skaicius didesnis arba lygus 10 siunciam ji is cia.
                }
                else
                {
                    return true;//jeigu mazesnis ir tinka salyga tai paskutinis skaicius.
                }
            }
            else
            {
                return false;//labai blogai.
            }
        }

    }
}
