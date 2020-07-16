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
    public partial class R_Stagiaire_Form : Form
    {
        BL.Stagiaire stgr = new BL.Stagiaire();
        private static R_Stagiaire_Form frm;
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

        public static R_Stagiaire_Form getForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new R_Stagiaire_Form();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public R_Stagiaire_Form()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = stgr.ListeStagiaire();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form frm = new R_Ajouter_Stagiaire();
            frm.ShowDialog();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = stgr.RechercherStagiaire(txtRechercher.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            R_Ajouter_Stagiaire frm = new R_Ajouter_Stagiaire();
            
            frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtNom.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtPrenom.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //frm. = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.lTitre.Text = "Modifier: " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.btnAjouter.Text = "Modifier";
            frm.cas = "Modifier";
            lTitre.Location = new Point(61, 43);
            frm.txtID.ReadOnly = true;
            frm.txtNom.Focus();
            frm.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer le stagiaire ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                stgr.SupprimerStagiair(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Stagiaire supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource =stgr.ListeStagiaire();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
