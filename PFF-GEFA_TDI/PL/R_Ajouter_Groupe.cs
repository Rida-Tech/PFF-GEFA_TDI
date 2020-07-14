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
    public partial class R_Ajouter_Groupe : Form
    {
        public string cas = "Ajouter";
        BL.Groupe grp = new BL.Groupe();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Ajouter_Groupe()
        {
            InitializeComponent();
            
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

        private void R_Ajouter_Groupe_Load(object sender, EventArgs e)
        {
            cbNiveau.Items.Add("T");
            cbNiveau.Items.Add("TS");
            cbAnnee.Items.Add("1A");
            cbAnnee.Items.Add("2A");
            cbAnnee.Items.Add("3A");
            cbNiveau.SelectedIndex = 0; cbAnnee.SelectedIndex = 0;
            cbCours.Items.Add("Cours de jour");
            cbCours.Items.Add("Cours de soir");
            cbCours.SelectedIndex = 0;
        }

        private void cbCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbFiliere.DataSource = grp.ListeFiliere_Choix(cbCours.Text);
                cbFiliere.DisplayMember = "Filiere";
                cbFiliere.ValueMember = "ID_Filiere";
                cbFiliere.SelectedIndex = 0;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cas == "Ajouter")
                {
                    if (txtID.Text != "" && txtGroupe.Text != "" && txtEffectif.Text != "")
                    {

                        grp.Ajouter_Groupe(Convert.ToInt32(txtID.Text), txtGroupe.Text, Convert.ToInt32(cbFiliere.SelectedValue), Convert.ToInt32(txtEffectif.Text), cbAnnee.Text, cbNiveau.Text);
                        MessageBox.Show("Groupe ajouter avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Merci de remplir les champs vides", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    grp.ModifierGroupe(Convert.ToInt32(txtID.Text), txtGroupe.Text, Convert.ToInt32(cbFiliere.SelectedValue), Convert.ToInt32(txtEffectif.Text), cbAnnee.Text, cbNiveau.Text);
                    MessageBox.Show("Groupe Modifier avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }
                R_Groupe_Form.getForm.dataGridView1.DataSource = grp.ListeGroupe();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            if (cas == "Ajouter")
            {
                DataTable dt = new DataTable();
                dt = grp.VerifierIDGroupe(txtID.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ce identifient existe déjà", "Erreur!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    txtID.SelectionStart = 0;
                    txtID.SelectionLength = txtID.TextLength;
                }
            }
        }
    }
}
