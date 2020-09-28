using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_TiesesTaskai
{
    interface ITaskas
    {
        double X { get; }
        double Y { get; }
        void Sukurti(double x, double y);
        void Spausdinti();
    }
}
