namespace PFF_GEFA_TDI.PL
{
    partial class R_Ajouter_Examen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lTitre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEpreuve = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtHeurD = new System.Windows.Forms.TextBox();
            this.txtHeurF = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lTitre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 89);
            this.panel1.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(524, 10);
            this.panel7.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PFF_GEFA_TDI.Properties.Resources.e2539;
            this.pictureBox1.Location = new System.Drawing.Point(479, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(136, 28);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(265, 33);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "Ajouter Un Enseignent";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 518);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 10);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 528);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(534, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 528);
            this.panel2.TabIndex = 17;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(206, 157);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(291, 34);
            this.txtType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Type Examen :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(206, 212);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(291, 34);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "JJ-MM-AAAA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date Examen :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Heur début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Heur fin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Epreuve :";
            // 
            // cbEpreuve
            // 
            this.cbEpreuve.FormattingEnabled = true;
            this.cbEpreuve.Location = new System.Drawing.Point(206, 377);
            this.cbEpreuve.Name = "cbEpreuve";
            this.cbEpreuve.Size = new System.Drawing.Size(291, 24);
            this.cbEpreuve.TabIndex = 4;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(206, 431);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(291, 50);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // txtHeurD
            // 
            this.txtHeurD.Location = new System.Drawing.Point(206, 267);
            this.txtHeurD.Multiline = true;
            this.txtHeurD.Name = "txtHeurD";
            this.txtHeurD.Size = new System.Drawing.Size(291, 34);
            this.txtHeurD.TabIndex = 2;
            this.txtHeurD.Text = "00:00";
            // 
            // txtHeurF
            // 
            this.txtHeurF.Location = new System.Drawing.Point(206, 322);
            this.txtHeurF.Multiline = true;
            this.txtHeurF.Name = "txtHeurF";
            this.txtHeurF.Size = new System.Drawing.Size(291, 34);
            this.txtHeurF.TabIndex = 3;
            this.txtHeurF.Text = "00:00";
            // 
            // R_Ajouter_Examen
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 528);
            this.Controls.Add(this.txtHeurF);
            this.Controls.Add(this.txtHeurD);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEpreuve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "R_Ajouter_Examen";
            this.Text = "R_Ajouter_Examen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEpreuve;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtHeurD;
        private System.Windows.Forms.TextBox txtHeurF;
    }
}