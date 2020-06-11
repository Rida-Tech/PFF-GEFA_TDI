using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFF_GEFA_TDI.PL
{
    public partial class R_Main_Form : Form
    {
        public static R_Main_Form form;
        public R_Main_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voullez vous vraiment quitter l'appliquation?","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btn_Enseignent_Click(object sender, EventArgs e)
        {
            Form frm = new R_Enseignent_Form();
            frm.ShowDialog();
        }

    }
}
