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
            GestionExamen GX = new GestionExamen();
            method.ShowContent(GX, Content);
        }
    }
}
