using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201001_KoldunuChamp
{
    class PrivalgytaKoldunuException:Exception
    {
        public int SuvalgytaKoldunu { get; }
        public int BuvoGalimaSuvalgyti { get; }
        public PrivalgytaKoldunuException(int suvalgyta, int galima)
        {
            SuvalgytaKoldunu = suvalgyta;
            BuvoGalimaSuvalgyti = galima;
        }
        public override string Message => "Suvalgyta " + SuvalgytaKoldunu + ", o buvo galima " + BuvoGalimaSuvalgyti;
    }
}
