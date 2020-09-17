using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200917_SkaiciavimoMasinele
{    
    public partial class Form1 : Form
    {
        private char veiksmas { get; set; }
        public Form1()
        {
            InitializeComponent();
            veiksmas = ' ';
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text += "3";
        }

        private void eqBtn_Click(object sender, EventArgs e)
        {
            VeiksmoTikrinimas();
            veiksmas = ' ';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(IvedimoTxtBx.Text.Length == 0)
            {
                IvedimoTxtBx.Text += "0.";
            }
            else
            {
                IvedimoTxtBx.Text += "0";
            }            
        }

        private void CEBtn_Click(object sender, EventArgs e)
        {
            IvedimoTxtBx.Text = "";
            IsvedimoTxtBx.Text = "";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            VeiksmoTikrinimas();
            veiksmas = '+';
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            VeiksmoTikrinimas();
            veiksmas = '-';
        }

        private void daugBtn_Click(object sender, EventArgs e)
        {
            VeiksmoTikrinimas();
            veiksmas = '*';
        }

        private void dalBtn_Click(object sender, EventArgs e)
        {
            VeiksmoTikrinimas();
            veiksmas = '/';
        }

        private void VeiksmoTikrinimas()
        {
            if (IsvedimoTxtBx.Text.Length == 0)
            {
                IsvedimoTxtBx.Text = IvedimoTxtBx.Text;
            }
            else if (!char.IsWhiteSpace(veiksmas))
            {
                IsvedimoTxtBx.Text = MatematinisVeikmas().ToString();
            }
            IvedimoTxtBx.Text = "";
        }

        private double MatematinisVeikmas()
        {
            if(veiksmas == '+')
            {
                return double.Parse(IsvedimoTxtBx.Text) + double.Parse(IvedimoTxtBx.Text);
            }
            else if (veiksmas == '-')
            {
                return double.Parse(IsvedimoTxtBx.Text) - double.Parse(IvedimoTxtBx.Text);

            }
            else if (veiksmas == '*')
            {
                return double.Parse(IsvedimoTxtBx.Text) * double.Parse(IvedimoTxtBx.Text);

            }
            else if (veiksmas == '/')
            {
                if(double.Parse(IvedimoTxtBx.Text) == 0)
                {
                    MessageBox.Show("Dalyba is nulio negalima");
                    return 0;
                }
                return double.Parse(IsvedimoTxtBx.Text) / double.Parse(IvedimoTxtBx.Text);
            }
            return 0;
        }
    }
}
