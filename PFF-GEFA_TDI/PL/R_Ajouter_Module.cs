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
    public partial class R_Ajouter_Module : Form
    {
        public string cas = "Ajouter";
        BL.Module mdl = new BL.Module();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Ajouter_Module()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cas == "Ajouter")
                {
                    if (txtID.Text != "" && txtNom.Text != "")
                    {
                       
                       
                            mdl.Ajouter_Module(Convert.ToInt32(txtID.Text), txtNom.Text);
                            MessageBox.Show("Module Ajouter avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Text = ""; txtNom.Text = "";
                        
                    }
                    else MessageBox.Show("Merci de remplir les champs vides", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mdl.ModifierModule(Convert.ToInt32(txtID.Text), txtNom.Text);
                    MessageBox.Show("Module Modifier avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                R_Module_Form.getForm.dataGridView1.DataSource = mdl.ListeModules();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            try
            {
                if (cas == "Ajouter")
                {
                    DataTable dt = new DataTable();
                    dt = mdl.VerifierIDModule(txtID.Text);
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

        private void panel1_Validated(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
