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
    public partial class R_Stagiaire_Form : Form
    {
        BL.Stagiaire stgr = new BL.Stagiaire();
        private static R_Stagiaire_Form frm;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static R_Stagiaire_Form getForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new R_Stagiaire_Form();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public R_Stagiaire_Form()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = stgr.ListeStagiaire();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form frm = new R_Ajouter_Stagiaire();
            frm.ShowDialog();
        }
    }
}
