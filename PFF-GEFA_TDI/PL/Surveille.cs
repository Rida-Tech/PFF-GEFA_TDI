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
    public partial class Surveille : UserControl
    {
        BL.Examen ex = new BL.Examen();
        public Surveille()
        {
            InitializeComponent();
            dataGridView1.DataSource = ex.liste_Surveille();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Form_Liste_Survillant frm = new Form_Liste_Survillant();
            frm.ShowDialog();
            txtIDensg.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnom.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprenom.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(txtIDensg.Text=="" || txtIDgrp.Text=="")
            {
                MessageBox.Show("Merci de choisir le groupe et l'enseignent", "Attention", MessageBoxButtons.OK);
            }
            else
            {
                ex.Ajouter_Surveille(Convert.ToInt32(txtIDensg.Text),Convert.ToInt32(txtIDgrp.Text));
                MessageBox.Show("Bien Ajouté", "Succèss", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.Form_List_Groupe grp = new Form_List_Groupe();
            grp.ShowDialog();
            txtIDgrp.Text= grp.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtgroupe.Text = grp.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ex.SupprimerSurville(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()), int.Parse(this.dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                MessageBox.Show("supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = ex.liste_Surveille();
            }
        }
    }
}
