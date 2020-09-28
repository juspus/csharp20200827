using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_TiesesTaskai
{
    class Taskas : ITaskas
    {
        public double X { get; }

        public double Y { get; }

        public Taskas(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Spausdinti()
        {
            throw new NotImplementedException();
        }

        public void Sukurti(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
