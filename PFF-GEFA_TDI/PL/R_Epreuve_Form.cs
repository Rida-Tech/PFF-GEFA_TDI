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
    public partial class R_Epreuve_Form : Form
    {
        string cas;
        BL.Epreuve epr = new BL.Epreuve();
        BL.Enseignent ensg = new BL.Enseignent();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Epreuve_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = epr.ListEpreuve();
            
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            try
            {
                if (cas == "Ajouter")
                {
                    DataTable dt = new DataTable();
                    dt = epr.VerifierIDEpreuve(txtID.Text);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Ce identifient existe déjà", "Erreur!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtID.Focus();
                        txtID.SelectionStart = 0;
                        txtID.SelectionLength = txtID.TextLength;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            epr.Ajouter_Epreuve(txtID.Text, txtEpreuve.Text,txtVariante.Text);
            MessageBox.Show("Ajout avec succèss");
            dataGridView1.DataSource = epr.ListEpreuve();
            btnNouveau.Visible = true; txtID.ReadOnly = true;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer l'epreuve ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                epr.SupprimerEpreuve(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("L'epreuve supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = epr.ListEpreuve();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = epr.VerifierIDEpreuve(txtID.Text);
            if (dt.Rows.Count > 0)
            {
                epr.ModifierEpreuve(txtID.Text, txtEpreuve.Text, txtVariante.Text);
                MessageBox.Show("Bien Modifier", "Succèss!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dataGridView1.DataSource = epr.ListEpreuve();
            }
            else
            {
                MessageBox.Show("Merci de choisir un epreuve valide", "Erreur!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEpreuve.Focus();
                
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true; txtEpreuve.ReadOnly = false; txtVariante.ReadOnly = false;
            btnNouveau.Visible = true;
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtID.Text = row.Cells[0].Value.ToString();
                txtEpreuve.Text = row.Cells[1].Value.ToString();
                txtVariante.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            btnNouveau.Visible = false; txtEpreuve.ReadOnly = false; txtVariante.ReadOnly = false;
            txtID.Text = "";txtEpreuve.Text = "";txtVariante.Text = "";
            txtID.ReadOnly = false;
        }

        private void R_Epreuve_Form_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;txtEpreuve.ReadOnly = true;txtVariante.ReadOnly = true;
        }
    }
}
