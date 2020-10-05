using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201005_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Point pt = new Point();
            pt.PointChanged += Pt_PointChanged;
            pt.X = 8;
            this.button1.FontChanged += pvzMetodas;
        }

        private void Pt_PointChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private void button1_FontChanged(object sender, EventArgs e)
        {

        }

        private void pvzMetodas(object sender, EventArgs e)
        {

        }
    }
}
