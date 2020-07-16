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
    public partial class Form_List_Groupe : Form
    {
        BL.Groupe grp = new BL.Groupe();
        public Form_List_Groupe()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.dataGridView1.DataSource = grp.ListeGroupe();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = grp.RechercherGroupe(txtRechercher.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
