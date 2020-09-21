using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200921PaveldejimaiPVz
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Gyvunas> gyvunai = new List<Gyvunas>();
            List<Suo> sunys = new List<Suo>();
            List<Roplys> terariumas = new List<Roplys>();

            Gyvunas gyv1 = new Gyvunas("Micius", 11);
            Suo suo1 = new Suo("Bliuzas", 5, "Korgis");
            Suo suo2 = new Suo("Korgas", 13, "Seltis");
            Varle var1 = new Varle("Varlius", 2);
            Driezas geko = new Driezas("Gekis", 1);
            Gyvunas vilk = new Gyvunas("Vilkis", 16);

            gyvunai.Add(gyv1);
            gyvunai.Add(suo2);
            gyvunai.Add(suo1);
            gyvunai.Add(var1);
            gyvunai.Add(geko);
            gyvunai.Add(vilk);

            terariumas.Add(var1);
            terariumas.Add((Roplys)gyv1);
            terariumas.Add(geko);

            sunys.Add(suo1);
            sunys.Add(suo2);

            foreach(Gyvunas gv in gyvunai)
            {
                gv.Info();
                Console.WriteLine();
            }

            //gyv1.Info();
            
            //suo1.Info();
            ;
        }
    }
}
