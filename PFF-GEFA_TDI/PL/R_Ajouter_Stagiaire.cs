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
   
    public partial class R_Ajouter_Stagiaire : Form
    {
        public string cas = "Ajouter";
        BL.Stagiaire stgr = new BL.Stagiaire();
        BL.Groupe grp = new BL.Groupe();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Ajouter_Stagiaire()
        {
            InitializeComponent();
            cbGoupe.DataSource = grp.ListeGroupe();
            cbGoupe.DisplayMember = "Groupe";
            cbGoupe.ValueMember = "Idantifiant";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cas == "Ajouter")
                {
                    if (txtID.Text != "" && txtNom.Text != "" && txtPrenom.Text != "" && txtEmail.Text != "")
                    {

                        stgr.Ajouter_Stagiaire(Convert.ToInt32(txtID.Text), txtNom.Text, txtPrenom.Text, txtEmail.Text, Convert.ToInt32(cbGoupe.SelectedValue));
                            MessageBox.Show("Stagiaire Ajouter avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Text = ""; txtNom.Text = ""; txtPrenom.Text = ""; txtEmail.Text = "";
                        
                    }
                    else MessageBox.Show("Merci de remplir les champs vides", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    stgr.ModifierStagiaire(Convert.ToInt32(txtID.Text), txtNom.Text, txtPrenom.Text, txtEmail.Text, Convert.ToInt32(cbGoupe.SelectedValue));
                    MessageBox.Show("Stagiaire Modifier avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                R_Stagiaire_Form.getForm.dataGridView1.DataSource = stgr.ListeStagiaire();
                

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
                    dt = stgr.VerifierIDStagiaire(txtID.Text);
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
