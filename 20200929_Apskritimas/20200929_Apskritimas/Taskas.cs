using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200929_Apskritimas
{
    class Taskas:IEquatable<Taskas>,IFormattable, IEqualityComparer<Taskas>
    {
        public int X { get; }
        public int Y { get; }
        public Taskas(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double AtstumasIkiTasko(Taskas taskas)
        {
            int x = taskas.X - X;
            int y = taskas.Y - Y;
            return Math.Sqrt( Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public bool Equals(Taskas other)
        {
            if(X == other.X && Y == other.Y)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "X: " + X + ", Y: " + Y;
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return "X: " + X + ", Y: " + Y;
        }

        public bool Equals(Taskas x, Taskas y)
        {
            if(x.X == y.X && x.Y==x.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Taskas obj)
        {
            throw new NotImplementedException();
        }
    }
}
