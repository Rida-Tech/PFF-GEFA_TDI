using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFF_GEFA_TDI.PL
{
    public partial class Form_Liste_Survillant : Form
    {
        BL.Enseignent ensg = new BL.Enseignent();
        public Form_Liste_Survillant()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = ensg.ListEnseignent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
