using _20201013_DatabaseUzduotis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201013_OrganaiDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ZmogausOrganaiConverterDataContext db = new ZmogausOrganaiConverterDataContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zmogausOrganaiDataSet.Zmogus' table. You can move, or remove it, as needed.
            this.zmogusTableAdapter.Fill(this.zmogausOrganaiDataSet.Zmogus);

        }
    }
}
