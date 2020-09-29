using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_Apskritimas
{
    class Apskritimas
    {
        public Taskas Centras { get; }
        public double Radius { get; }

        public Apskritimas(Taskas centras, double spindulys)
        {
            Centras = centras;
            Radius = spindulys;
        }

        public bool ArTaskasApskritimoViduje(Taskas taskas)
        {
            if(Centras.AtstumasIkiTasko(taskas) < Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
