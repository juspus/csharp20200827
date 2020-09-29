using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_InterfaceDaerbuotojas
{
    class Testuotojas:IDarbuotojas
    {
        public string Vardas { get; }

        public int Id { get; }
        public Testuotojas(string vardas, int id)
        {
            Vardas = vardas;
            Id = id;
        }

        public void SpausdintiInfo()
        {
            Console.WriteLine("Testuotojo vardas: {0} ir ID {1}", Vardas, Id);
        }
    }
}
