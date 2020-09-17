using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200907_Prisijungimas
{
    public partial class PrisijungimoForma : Form
    {
        private List<Vartotojas> vartotojai { get; set; }
        private string vartotojoVardas {get; set;}
        private string vartotojoSlaptazodis { get; set; }
        public PrisijungimoForma()
        {
            InitializeComponent();
            vartotojai = new List<Vartotojas>();
            vartotojai.Add(new Vartotojas("Justas", "55646"));
            vartotojai.Add(new Vartotojas("vardas", "slaptunas"));
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            vartotojoVardas = vartotojasTxtBx.Text;
            vartotojoSlaptazodis = passwordTxtBx.Text;

            if(VartotojasTeisingas())
            {
                prisijungusioVardLbl.Text = vartotojoVardas;
                statusIndLbl.Text = "Prisijungta";
                statusIndLbl.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Blogai ivestas vartotojas!");
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            vartotojoVardas = "";
            vartotojoSlaptazodis = "";

            prisijungusioVardLbl.Text = vartotojoVardas;
            statusIndLbl.Text = "Neprisijungta";
            statusIndLbl.ForeColor = Color.Red;
        }

        private bool VartotojasTeisingas()
        {
            foreach(var user in vartotojai)
            {
                if(user.ArEgzistuoja(vartotojoVardas, vartotojoSlaptazodis))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
