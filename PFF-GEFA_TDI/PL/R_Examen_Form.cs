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
    public partial class R_Examen_Form : Form
    {
        DAL.DataAccessLayer method = new DAL.DataAccessLayer();
        private static R_Examen_Form frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static R_Examen_Form getForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new R_Examen_Form();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public R_Examen_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionExamen GX = new GestionExamen();
            method.ShowContent(GX, panel5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Surveille surville = new Surveille();
            method.ShowContent(surville, panel5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Passer passer = new Passer();
            method.ShowContent(passer, panel5);
        }
    }
}
