using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20200921PaveldejimaiPVz
{
    public class Gyvunas
    {
        protected string Vardas { get; set; }
        protected int Amzius { get; set; }

        public Gyvunas(string vardas, int amzius)
        {
            Vardas = vardas;
            Amzius = amzius;
        }

        public virtual void Info()
        {
            Console.WriteLine("Vardas: " + Vardas);
            Console.WriteLine("Amzius: " + Amzius);
        }
    }

    public class Suo : Zinduolis
    {
        public string Veisle { get; set; }
        public Suo (string vardas, int amzius, string veisle):base(vardas, amzius)
        {
            Veisle = veisle;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Veisle: "+Veisle);
        }
    }

    public class Zinduolis :Gyvunas
    {
        public Zinduolis(string vardas, int amzius):base(vardas, amzius)
        {

        }
    }

    public class Roplys : Gyvunas
    {
        public Roplys(string vardas, int amzius):base(vardas, amzius)
        {

        }
    }

    public class Varle : Roplys
    {
        public Varle(string vardas, int amzius):base(vardas, amzius)
        {

        }
    }

    public class Driezas : Roplys
    {
        public Driezas(string vardas, int amzius) : base(vardas, amzius)
        {

        }
    }
}
