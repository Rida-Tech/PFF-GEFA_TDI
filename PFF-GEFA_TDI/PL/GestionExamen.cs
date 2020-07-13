using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFF_GEFA_TDI.PL
{
    public partial class GestionExamen : UserControl
    {
        DAL.DataAccessLayer method = new DAL.DataAccessLayer();
        public GestionExamen()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            R_Ajouter_Examen frm = new R_Ajouter_Examen();
            frm.ShowDialog();
        }
    }
}
