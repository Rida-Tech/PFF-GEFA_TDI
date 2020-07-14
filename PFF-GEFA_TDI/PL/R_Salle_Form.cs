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
    public partial class R_Salle_Form : Form
    {
        BL.Salle salle = new BL.Salle();
        private static R_Salle_Form frm;
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
        public static R_Salle_Form getForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new R_Salle_Form();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public R_Salle_Form()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = salle.ListeSalle();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form frm = new R_Ajouter_Salle();
            frm.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer la salle ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                salle.SupprimerSalle(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("La Salle est supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = salle.ListeSalle();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            R_Ajouter_Salle frm = new R_Ajouter_Salle();
            frm.txtnum.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtType.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtCapacite.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.lTitre.Text = "Modifier Salle";
            frm.btnAjouter.Text = "Modifier";
            frm.cas = "Modifier";
            frm.txtnum.ReadOnly = true;
            frm.txtType.Focus();
            frm.ShowDialog();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = salle.RechercherSalle(txtRechercher.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
