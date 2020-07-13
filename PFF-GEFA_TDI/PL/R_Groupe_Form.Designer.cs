namespace PFF_GEFA_TDI.PL
{
    partial class R_Groupe_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImprimerTout = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1301, 10);
            this.panel6.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 94);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PFF_GEFA_TDI.Properties.Resources.e2539;
            this.pictureBox1.Location = new System.Drawing.Point(1257, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Groupes";
            // 
            // txtRechercher
            // 
            this.txtRechercher.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.Location = new System.Drawing.Point(284, 119);
            this.txtRechercher.Multiline = true;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(926, 36);
            this.txtRechercher.TabIndex = 14;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rechercher:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 635);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1301, 10);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1311, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 645);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 645);
            this.panel2.TabIndex = 12;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Location = new System.Drawing.Point(529, 37);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(226, 41);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimer.Location = new System.Drawing.Point(297, 37);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(226, 41);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Location = new System.Drawing.Point(65, 37);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(226, 41);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImprimerTout);
            this.groupBox2.Controls.Add(this.btnImprimer);
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.btnSupprimer);
            this.groupBox2.Controls.Add(this.btnAjouter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1285, 110);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opération de mise à jour :";
            // 
            // btnImprimerTout
            // 
            this.btnImprimerTout.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnImprimerTout.FlatAppearance.BorderSize = 0;
            this.btnImprimerTout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimerTout.Location = new System.Drawing.Point(993, 37);
            this.btnImprimerTout.Name = "btnImprimerTout";
            this.btnImprimerTout.Size = new System.Drawing.Size(226, 41);
            this.btnImprimerTout.TabIndex = 4;
            this.btnImprimerTout.Text = "Imprimer la liste";
            this.btnImprimerTout.UseVisualStyleBackColor = false;
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnImprimer.FlatAppearance.BorderSize = 0;
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimer.Location = new System.Drawing.Point(761, 37);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(226, 41);
            this.btnImprimer.TabIndex = 3;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1285, 340);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Groupes :";
            // 
            // R_Groupe_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "R_Groupe_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R_Groupe_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImprimerTout;
        private System.Windows.Forms.Button btnImprimer;
    }
}