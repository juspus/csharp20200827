using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200928_TiesesTaskai
{
    class Linija : ITiese
    {
        public ITaskas Start { get; private set; }

        public ITaskas End { get; private set; }
        private double k { get; set; }
        private double b { get; set; }

        private void SuskaiciuotiKofus()
        {
            k = (Start.Y - End.Y) / (Start.X - End.X);
            b = End.Y - k * End.X;
        }

        public bool ArTieseje(ITaskas taskas)
        {
            return taskas.Y == k * taskas.X + b;
        }

        public void Sukurti(ITaskas start, ITaskas end)
        {
            Start = start;
            End = end;
        }
    }
}
