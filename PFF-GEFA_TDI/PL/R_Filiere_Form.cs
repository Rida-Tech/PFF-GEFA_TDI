using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PFF_GEFA_TDI.PL
{
    public partial class R_Filiere_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS; Database=PFF_GEFA_TDI; Integrated security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public R_Filiere_Form()
        {
            InitializeComponent();
            
            this.ShowInTaskbar = false;
            da = new SqlDataAdapter("SELECT ID_Filiere as 'Identifiant', Filiere as 'Nom Filière',Cours as 'Type de Cours',Niveau From Filiere", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtNom.DataBindings.Add("text", dt, "Nom Filière");
            txtCours.DataBindings.Add("text", dt, "Type de Cours");
            
            bmb = this.BindingContext[dt];
            lPosition.Text = (bmb.Position+1) + " / " + bmb.Count;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            btnAjouter.Visible = false;
            btnNouveau.Visible = true;
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            lPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            MessageBox.Show("la filière a été ajouté avec succès ", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtCours.Text != "")
            {
                btnAjouter.Enabled = true;
            }
            else btnAjouter.Enabled = false;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            btnAjouter.Visible = true;
            btnNouveau.Visible = false;
            bmb.AddNew();
            txtNom.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            lPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            MessageBox.Show("la filière a été supprimé avec succès ", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            lPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            MessageBox.Show("la filière a été Modifier avec succès ", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void R_Filiere_Form_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[0].Width = 80;
            this.dataGridView1.Columns[2].Width = 150;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
