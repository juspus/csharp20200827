using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _20201005_DelegataiZmones.Zmogus;

namespace _20201005_DelegataiZmones
{
    public static class AmziausTikrinimas
    {
        public static AmziausGrupe KokiaGrupe(int amzius)
        {
            if(amzius<0)
            {
                throw new ArgumentOutOfRangeException("amzius","Amzius negali buti maziau uz nuli!");
            }
            if (amzius < 18)
            {
                return AmziausGrupe.Vaikas;
            }
            else if (amzius < 65)
            {
                return AmziausGrupe.Suauges;
            }
            else if (amzius >= 65)
            {
                return AmziausGrupe.Senolis;
            }
            else
            {
                return AmziausGrupe.Nezinoma;
            }           
        }
    }
}
