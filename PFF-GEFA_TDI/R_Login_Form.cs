using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PFF_GEFA_TDI
{
    public partial class R_Login_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS ; Integrated security=true; Initial catalog=PFF_GEFA_TDI");
        public R_Login_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voullez vous vraiment quitter?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //this part make the form maveable after i make it borderless...
        //from this==>{........
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //if you click and hold on the top of the form you can move it..
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Also on the label(Authentification) click and hold to move the form
        private void lTitre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Nom,Password from Login", con);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (textBox1.Text == dr[0].ToString() && textBox2.Text == dr[1].ToString())
                {
                    Form frm = new R_Main_Form();
                    Form frm2 = new R_Login_Form();
                    frm.Show();
                    MessageBox.Show("Bienvenue Mr/Md " + dr[0].ToString() + ".", "BIENVENUE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm2.Visible = false;
                }
                else MessageBox.Show("Mot de passe ou Nom d'utilisateur incorrect!! Ressayer...", "Message D'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        // To this.
        //.....}

    }
}
