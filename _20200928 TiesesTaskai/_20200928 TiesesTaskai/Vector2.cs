using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_TiesesTaskai
{
    class Vector2 : ITaskas
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public void Spausdinti()
        {
            Console.WriteLine("X: {0}, Y: {1}",X ,Y);
        }

        public void Sukurti(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
