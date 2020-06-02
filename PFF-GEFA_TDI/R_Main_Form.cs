using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFF_GEFA_TDI
{
    public partial class R_Main_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS ; Integrated security=true; Initial catalog=PFF_GEFA_TDI");
        public R_Main_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment quitter le programme ?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lDeconnecter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Hide();
                var frm = new R_Login_Form();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
            
        }
    }
}
