using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201013_LinqUzklausos
{
    class Zmogus
    {
        public int Id { get; }
        public double Svoris { get; set; }
        public double Ugis { get; set; }

        public Zmogus(int id, double svoris, double ugis)
        {
            Id = id;
            Svoris = svoris;
            Ugis = ugis;
        }

        public double ApskaiciuotiKMI()
        {
            return Svoris/Math.Pow(Ugis, 2)*10000;
        }
    }
}
