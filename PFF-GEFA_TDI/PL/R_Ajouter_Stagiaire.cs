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
   
    public partial class R_Ajouter_Stagiaire : Form
    {
        BL.Stagiaire stgr = new BL.Stagiaire();
        BL.Groupe grp = new BL.Groupe();
        public R_Ajouter_Stagiaire()
        {
            InitializeComponent();
            cbGoupe.DataSource = grp.ListeGroupe();
            cbGoupe.DisplayMember = "Groupe";
            cbGoupe.ValueMember = "Groupe";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
