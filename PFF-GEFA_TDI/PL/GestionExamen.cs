using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFF_GEFA_TDI.PL
{
    public partial class GestionExamen : UserControl
    {
        DAL.DataAccessLayer method = new DAL.DataAccessLayer();
        BL.Examen ex = new BL.Examen();
        
        public GestionExamen()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = ex.ListExamen();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            R_Ajouter_Examen frm = new R_Ajouter_Examen();
            frm.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer l'examen ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ex.SupprimerExamen(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("L'examen supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = ex.ListExamen();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            R_Ajouter_Examen frm = new R_Ajouter_Examen();
            frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.cbType.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.dateExamen.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtHeurD.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtHeurF.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.lTitre.Text = "Modifier Examen";
            frm.btnAjouter.Text = "Modifier";
            frm.cas = "Modifier";
            frm.ShowDialog();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            RPT.Calendrie_Examen rpt = new RPT.Calendrie_Examen();
            RPT.R_Form_RPT frm = new RPT.R_Form_RPT();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
    }
}
