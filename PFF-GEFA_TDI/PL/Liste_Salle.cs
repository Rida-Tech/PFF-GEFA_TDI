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
    public partial class Liste_Salle : Form
    {
        BL.Salle sl = new BL.Salle();
        public Liste_Salle()
        {
            InitializeComponent();
            dataGridView1.DataSource = sl.ListeSalle();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
