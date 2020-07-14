using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFF_GEFA_TDI.PL
{
    public partial class R_Groupe_Form : Form
    {
        BL.Groupe grp = new BL.Groupe();
        private static R_Groupe_Form frm;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static R_Groupe_Form getForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new R_Groupe_Form();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public R_Groupe_Form()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = grp.ListeGroupe();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer le Groupe ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grp.SupprimerGroupe(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Le groupe supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = grp.ListeGroupe();
            }
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = grp.RechercherGroupe(txtRechercher.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form frm = new R_Ajouter_Groupe();
            frm.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            R_Ajouter_Groupe frm = new R_Ajouter_Groupe();
            frm.cbFiliere.Items.Clear();
            frm.cbCours.Items.Clear();
            frm.cbNiveau.Items.Clear();
            frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.cbNiveau.Text= this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtGroupe.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.cbFiliere.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cbCours.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtEffectif.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.cbAnnee.SelectedIndex = frm.cbAnnee.FindString(this.dataGridView1.CurrentRow.Cells[6].Value.ToString());
           
            frm.lTitre.Text = "Modifier: " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnAjouter.Text = "Modifier";
            frm.cas = "Modifier";
            frm.txtID.ReadOnly = true;
            frm.txtGroupe.Focus();
            frm.ShowDialog();
        }

        private void btnImprimerTout_Click(object sender, EventArgs e)
        {
            RPT.Liste_groupe rpt = new RPT.Liste_groupe();
            rpt.SetParameterValue("@id", this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            RPT.R_Form_RPT frm = new RPT.R_Form_RPT();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
    }
}
