﻿using System;
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
        PL.R_Login_Form log=new R_Login_Form();
        public R_Main_Form()
        {
            InitializeComponent();
            timer1.Start();
            label4.Text = log.txtnom.Text;
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

        private void btnStagiaire_Click(object sender, EventArgs e)
        {
            Form frm = new R_Stagiaire_Form();
            frm.ShowDialog();
        }

        private void btnEpreuve_Click(object sender, EventArgs e)
        {
            Form frm = new R_Epreuve_Form();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new R_Examen_Form();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new R_Utilisateur();
            frm.ShowDialog();
        }
    }
}
