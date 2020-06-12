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
    public partial class R_Ajouter_Salle : Form
    {
        public string cas = "Ajouter";
        BL.Salle salle = new BL.Salle();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Ajouter_Salle()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cas == "Ajouter")
                {
                    if (txtnum.Text != "" && txtType.Text != "" && txtCapacite.Text!="")
                    {
                        salle.Ajouter_Salle(txtnum.Text, txtType.Text,Convert.ToInt32(txtCapacite.Text));
                        MessageBox.Show("Salle Ajouter avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnum.Text = ""; txtType.Text = ""; txtCapacite.Text = "";

                    }
                    else MessageBox.Show("Merci de remplir les champs vides", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    salle.ModifierSalle(txtnum.Text, txtType.Text, Convert.ToInt32(txtCapacite.Text));
                    MessageBox.Show("salle Modifier avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                R_Salle_Form.getForm.dataGridView1.DataSource = salle.ListeSalle();

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

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
