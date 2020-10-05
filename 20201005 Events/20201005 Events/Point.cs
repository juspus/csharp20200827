using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201005_Events
{
    class Point
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                OnPointChanged();
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPointChanged();
            }
        }

        public event EventHandler PointChanged;
        public override string ToString()
        {
            return X + " " + Y;
        }
        public void OnPointChanged()
        {
            if(PointChanged != null)
            {
                PointChanged(this, EventArgs.Empty);
            }
        }
    }
}
