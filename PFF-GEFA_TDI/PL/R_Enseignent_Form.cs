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
    public partial class R_Enseignent_Form : Form
    {
        BL.Enseignent ensg = new BL.Enseignent();
        public R_Enseignent_Form()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = ensg.ListEnseignent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form frm = new R_Ajouter_Enseignent();
            frm.ShowDialog();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ensg.RechercherEnseignent(txtRechercher.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
