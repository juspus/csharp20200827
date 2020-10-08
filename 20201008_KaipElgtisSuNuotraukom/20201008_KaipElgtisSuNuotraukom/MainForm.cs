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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            Form1 paveiksliukuForma = new Form1();
            paveiksliukuForma.KeistiLanga += KeistiForma;
            paveiksliukuForma.TopLevel = false;
            panel1.Controls.Add(paveiksliukuForma);
            paveiksliukuForma.Show();
        }

        public void KeistiForma(Form form)
        {
            form.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Show();
        }
    }
}
