using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201008_KaipElgtisSuNuotraukom
{
    public partial class AntrasLangas : Form
    {
        Action<Form> keistiLanga;
        public AntrasLangas(string pavPath, Action<Form> kl)
        {
            InitializeComponent();
            keistiLanga = kl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1();
            forma.KeistiLanga = keistiLanga;
            keistiLanga(forma);
        }
    }
}
