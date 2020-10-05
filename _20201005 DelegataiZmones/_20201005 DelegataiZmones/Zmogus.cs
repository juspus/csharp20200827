using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201005_DelegataiZmones
{
    public class Zmogus
    {
        public string Vardas { get; }
        public int Amzius { get; }
        public AmziausGrupe Grupe { get; }
        public delegate AmziausGrupe CheckGrupe(int amzius);

        public enum AmziausGrupe
        {
            Vaikas, // iki 18
            Suauges, // iki 65
            Senolis,
            Nezinoma
        }

        public Zmogus(string duomenuEilute, CheckGrupe check)
        {
            string[] duomenys = duomenuEilute.Split(',');
            Grupe = AmziausGrupe.Nezinoma;
            Vardas = duomenys[0];
            Amzius = int.Parse(duomenys[1]);
            Grupe = check(Amzius);
        }
    }
}
