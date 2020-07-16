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
    public partial class liste_examens : Form
    {
        BL.Examen ex = new BL.Examen();
        public liste_examens()
        {
            InitializeComponent();
            dataGridView1.DataSource = ex.ListExamen();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
