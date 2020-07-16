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
    public partial class Passer : UserControl
    {
        BL.Examen ex = new BL.Examen();
        public Passer()
        {
            InitializeComponent();
            dataGridView1.DataSource = ex.list_Passer();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtIDexamen.Text == "" || txtIDgrp.Text == "")
            {
                MessageBox.Show("Merci de choisir le groupe et l'examen", "Attention", MessageBoxButtons.OK);
            }
            else
            {
                ex.Ajouter_Passer(Convert.ToInt32(txtIDexamen.Text), Convert.ToInt32(txtIDgrp.Text));
                MessageBox.Show("Bien Ajouté", "Succèss", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.Form_List_Groupe grp = new Form_List_Groupe();
            grp.ShowDialog();
            txtIDgrp.Text = grp.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtgroupe.Text = grp.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.liste_examens frm = new liste_examens();
            frm.ShowDialog();
            txtIDexamen.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtType.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDate.Text= frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEpreuve.Text= frm.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ex.SupprimerPasser(int.Parse(this.dataGridView1.CurrentRow.Cells[3].Value.ToString()), int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = ex.list_Passer();
            }
        }
    }
}
