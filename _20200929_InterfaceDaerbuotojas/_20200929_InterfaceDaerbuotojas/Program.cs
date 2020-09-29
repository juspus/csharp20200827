using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_InterfaceDaerbuotojas
{
    class Program
    {
        static void Main(string[] args)
        {
            Darbininkas vadove = new Darbininkas("Justina", 0);
            Programuotojas p1 = new Programuotojas("Justas", 1);
            Programuotojas p2 = new Programuotojas("Petras", 2);
            Testuotojas t1 = new Testuotojas("Tomas", 3);
            Testuotojas t2 = new Testuotojas("Aloyzas", 659);

            Imone kcs = new Imone(vadove);
            kcs.Darbuotojai.Add(p1);            
            kcs.Darbuotojai.Add(t1);
            kcs.Darbuotojai.Add(p2);
            kcs.Darbuotojai.Add(t2);

            kcs.TrueDarbuotojoInfo(659);
            Console.WriteLine();
            Console.WriteLine();
            kcs.VisuDarbuotojuInfo();
            Console.WriteLine();
            Console.WriteLine();
            kcs.DarbuotojoInfo(2);
            Console.Read();
        }
    }
}
