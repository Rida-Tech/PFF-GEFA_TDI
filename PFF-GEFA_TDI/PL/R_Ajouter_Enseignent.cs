using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PFF_GEFA_TDI.PL
{
    public partial class R_Ajouter_Enseignent : Form
    {
        public string cas = "Ajouter";
        BL.Enseignent ensg = new BL.Enseignent();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Ajouter_Enseignent()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if(cas=="Ajouter")
                {
                    if (txtID.Text != "" && txtNom.Text != "" && txtPrenom.Text != "" && txtTel.Text != "" && txtEmail.Text != "")
                    {
                        ensg.AjouterEnseignent(Convert.ToInt32(txtID.Text), txtNom.Text, txtPrenom.Text, txtTel.Text, txtEmail.Text);
                        MessageBox.Show("Enseignent Ajouter avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = ""; txtNom.Text = ""; txtPrenom.Text = ""; txtTel.Text = ""; txtEmail.Text = "";

                    }
                    else MessageBox.Show("Merci de remplir les champs vides", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ensg.ModifierEnseignent(Convert.ToInt32(txtID.Text), txtNom.Text, txtPrenom.Text, txtTel.Text, txtEmail.Text);
                    MessageBox.Show("Enseignent Modifier avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                R_Enseignent_Form.getForm.dataGridView1.DataSource = ensg.ListEnseignent();
                
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

        private void txtID_Validated(object sender, EventArgs e)
        {
            try
            {
                if (cas=="Ajouter")
                {
                    DataTable dt = new DataTable();
                    dt = ensg.VerifierID(txtID.Text);
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

        // Forcer la zone de text a n'accepter que des chiffres
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // Set l'evenement comme etant completement fini
                return;
            }
        }

        // Forcer la zone de text a n'accepter que des chiffres
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // Set l'evenement comme etant completement fini
                return;
            }
        }

        private void R_Ajouter_Enseignent_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
