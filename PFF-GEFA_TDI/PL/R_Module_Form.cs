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
    public partial class R_Module_Form : Form
    {
        BL.Module mdl = new BL.Module();
        private static R_Module_Form frm;
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
        public static R_Module_Form getForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new R_Module_Form();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public R_Module_Form()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = mdl.ListeModules();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form frm = new R_Ajouter_Module();
            frm.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer le Module ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mdl.SupprimerModule(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("L'enseignent supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = mdl.ListeModules();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            R_Ajouter_Module frm = new R_Ajouter_Module();
            frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtNom.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.lTitre.Text = "Modifier Module";
            frm.btnAjouter.Text = "Modifier";
            frm.cas = "Modifier";
            frm.txtID.ReadOnly = true;
            frm.txtNom.Focus();
            frm.ShowDialog();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = mdl.RechercherModule(txtRechercher.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
