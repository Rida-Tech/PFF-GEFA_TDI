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
            timer1.Start();
            label3.Text= DateTime.Now.ToString("D");
            label2.Text = "ISTA NTIC Sidi youssef Ben Ali Marrakech";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new Exite();
            frm.ShowDialog();
            
        }

        private void btn_Enseignent_Click(object sender, EventArgs e)
        {
            Form frm = new R_Enseignent_Form();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Location = new Point(label2.Location.X + 5, label2.Location.Y);

            if (label2.Location.X > this.Width)
            {
                label2.Location = new Point(0 - label2.Width, label2.Location.Y);
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            Form frm = new R_Module_Form();
            frm.ShowDialog();
        }

        private void R_Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnSalles_Click(object sender, EventArgs e)
        {
            Form frm = new R_Salle_Form();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new R_Filiere_Form();
            frm.ShowDialog();
        }

        private void btnGroupes_Click(object sender, EventArgs e)
        {
            Form frm = new R_Groupe_Form();
            frm.ShowDialog();
        }
    }
}
