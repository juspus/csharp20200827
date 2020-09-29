using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_InterfaceDaerbuotojas
{
    class Darbininkas : IDarbuotojas
    {
        public string Vardas { get; }
        public int Id { get; }

        public Darbininkas(string vardas, int id)
        {
            Vardas = vardas;
            Id = id;
        }

        public void SpausdintiInfo()
        {
            Console.WriteLine("Darbininko vardas: {0} ir ID {1}", Vardas, Id);
        }
    }
}
