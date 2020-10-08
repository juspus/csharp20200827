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
    public partial class Form1 : Form
    {
        string[] paveiksliukai = new string[0];
        int counter = 0;
        public Action<Form> KeistiLanga;
        public Form1()
        {
            InitializeComponent();
            paveiksliukai = System.IO.Directory.GetFiles(@"Image\");
            SetImage(paveiksliukai[0]);
            panel1.Visible = false;
            
        }

        public void SetImage(string path)
        {
            pictureBox1.Image = Image.FromFile(path);
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(++counter>paveiksliukai.Count())
            {
                counter = 0;
            }
            if(counter == 3)
            {
                panel1.Visible = true;
                counter = 0;
            }
            SetImage(paveiksliukai[counter]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KeistiLanga(new AntrasLangas(paveiksliukai[0], KeistiLanga));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
