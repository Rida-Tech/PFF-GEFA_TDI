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
    public partial class Form_List_Epreuve : Form
    {
        BL.Epreuve ep = new BL.Epreuve();
        public Form_List_Epreuve()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.dataGridView1.DataSource = ep.ListEpreuve();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ep.RechercherEpreuve(txtRechercher.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
