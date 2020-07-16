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
    public partial class R_Ajouter_Examen : Form
    {
        public string cas = "Ajouter";
        BL.Examen ex = new BL.Examen();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Ajouter_Examen()
        {
            InitializeComponent();
            cbType.Items.Add("Fin Formation"); cbType.Items.Add("Examen de Passage");
            cbType.SelectedIndex = 0;
            txtID.Text = ex.ID_Examen().Rows[0][0].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_List_Epreuve frm = new Form_List_Epreuve();
            frm.ShowDialog();
            this.txtIDepreuve.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtepreuve.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txtvariante.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cas == "Ajouter")
                {

                    ex.Ajouter_Examen(cbType.Text, dateExamen.Text, txtHeurD.Text, txtHeurF.Text, txtIDepreuve.Text);
                            MessageBox.Show("Examen Ajouter avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    ex.ModifierExamen(Convert.ToInt32(txtID.Text), cbType.Text, dateExamen.Text, txtHeurD.Text, txtHeurF.Text, txtIDepreuve.Text);
                    MessageBox.Show("Examen Modifier avec succèss...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
