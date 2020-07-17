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
    public partial class Affecter : UserControl
    {
        BL.Examen ex = new BL.Examen();
        public Affecter()
        {
            InitializeComponent();
            dataGridView1.DataSource = ex.List_Affecter();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(txtIDgrp.Text=="" || txtnumSalle.Text=="")
            {
                MessageBox.Show("Merci de choisir le groupe et la salle", "Attention", MessageBoxButtons.OK);
            }
            else
            {
                if(int.Parse(txtEffectif.Text) > int.Parse(txtCapacite.Text))
                {
                    MessageBox.Show("la capacité de salle est insuffisant pour ce groupe", "Attention", MessageBoxButtons.OK);
                }
                else
                {
                    ex.Ajouter_Affecter(txtnumSalle.Text, int.Parse(txtIDgrp.Text));
                    MessageBox.Show("Bien Ajouté", "Succèss", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.Form_List_Groupe grp = new Form_List_Groupe();
            grp.ShowDialog();
            txtIDgrp.Text = grp.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtgroupe.Text = grp.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEffectif.Text = grp.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Liste_Salle salle = new Liste_Salle();
            salle.ShowDialog();
            txtnumSalle.Text = salle.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtType.Text = salle.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCapacite.Text = salle.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous vraiment supprimer ?", "Question ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ex.SupprimerAffecter(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), int.Parse(this.dataGridView1.CurrentRow.Cells[2].Value.ToString()));
                MessageBox.Show("supprimer avec succèss", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = ex.List_Affecter();
            }
        }
    }
}
