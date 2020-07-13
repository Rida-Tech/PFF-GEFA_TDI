namespace PFF_GEFA_TDI.PL
{
    partial class R_Main_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEpreuve = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnStagiaire = new System.Windows.Forms.Button();
            this.btnSalles = new System.Windows.Forms.Button();
            this.btnGroupes = new System.Windows.Forms.Button();
            this.btn_Enseignent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1773, 105);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PFF_GEFA_TDI.Properties.Resources.logo_offpt;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(1484, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nizar Cocon Kurdish", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des examens de fin d\'année";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PFF_GEFA_TDI.Properties.Resources.icons8_fermer_80;
            this.pictureBox1.Location = new System.Drawing.Point(1713, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1773, 62);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(792, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEpreuve
            // 
            this.btnEpreuve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEpreuve.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEpreuve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEpreuve.FlatAppearance.BorderSize = 0;
            this.btnEpreuve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEpreuve.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEpreuve.Image = global::PFF_GEFA_TDI.Properties.Resources.e0813;
            this.btnEpreuve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEpreuve.Location = new System.Drawing.Point(1083, 327);
            this.btnEpreuve.Name = "btnEpreuve";
            this.btnEpreuve.Size = new System.Drawing.Size(492, 76);
            this.btnEpreuve.TabIndex = 9;
            this.btnEpreuve.Text = "Gestion des Epreuves";
            this.btnEpreuve.UseVisualStyleBackColor = false;
            this.btnEpreuve.Click += new System.EventHandler(this.btnEpreuve_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::PFF_GEFA_TDI.Properties.Resources.e0813;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(197, 474);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(492, 76);
            this.button8.TabIndex = 8;
            this.button8.Text = "Gestion Des Examens";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::PFF_GEFA_TDI.Properties.Resources.e1343;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(1083, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(492, 76);
            this.button7.TabIndex = 7;
            this.button7.Text = "Gestion des Filières";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnStagiaire
            // 
            this.btnStagiaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStagiaire.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStagiaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStagiaire.FlatAppearance.BorderSize = 0;
            this.btnStagiaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStagiaire.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStagiaire.Image = global::PFF_GEFA_TDI.Properties.Resources.e0831;
            this.btnStagiaire.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStagiaire.Location = new System.Drawing.Point(197, 181);
            this.btnStagiaire.Name = "btnStagiaire";
            this.btnStagiaire.Size = new System.Drawing.Size(492, 76);
            this.btnStagiaire.TabIndex = 5;
            this.btnStagiaire.Text = "Gestion des Stagiaires";
            this.btnStagiaire.UseVisualStyleBackColor = false;
            this.btnStagiaire.Click += new System.EventHandler(this.btnStagiaire_Click);
            // 
            // btnSalles
            // 
            this.btnSalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalles.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalles.FlatAppearance.BorderSize = 0;
            this.btnSalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalles.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalles.Image = global::PFF_GEFA_TDI.Properties.Resources.telecommuting;
            this.btnSalles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalles.Location = new System.Drawing.Point(197, 327);
            this.btnSalles.Name = "btnSalles";
            this.btnSalles.Size = new System.Drawing.Size(492, 76);
            this.btnSalles.TabIndex = 4;
            this.btnSalles.Text = "Gestion des Salles";
            this.btnSalles.UseVisualStyleBackColor = false;
            this.btnSalles.Click += new System.EventHandler(this.btnSalles_Click);
            // 
            // btnGroupes
            // 
            this.btnGroupes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGroupes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGroupes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroupes.FlatAppearance.BorderSize = 0;
            this.btnGroupes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGroupes.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupes.Image = global::PFF_GEFA_TDI.Properties.Resources.multiple_users_silhouette;
            this.btnGroupes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGroupes.Location = new System.Drawing.Point(1083, 35);
            this.btnGroupes.Name = "btnGroupes";
            this.btnGroupes.Size = new System.Drawing.Size(492, 76);
            this.btnGroupes.TabIndex = 3;
            this.btnGroupes.Text = "Gestion des Groupes";
            this.btnGroupes.UseVisualStyleBackColor = false;
            this.btnGroupes.Click += new System.EventHandler(this.btnGroupes_Click);
            // 
            // btn_Enseignent
            // 
            this.btn_Enseignent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Enseignent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Enseignent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enseignent.FlatAppearance.BorderSize = 0;
            this.btn_Enseignent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Enseignent.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enseignent.Image = global::PFF_GEFA_TDI.Properties.Resources.e0813;
            this.btn_Enseignent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Enseignent.Location = new System.Drawing.Point(197, 35);
            this.btn_Enseignent.Name = "btn_Enseignent";
            this.btn_Enseignent.Size = new System.Drawing.Size(492, 76);
            this.btn_Enseignent.TabIndex = 1;
            this.btn_Enseignent.Text = "Gestion des Enseignents";
            this.btn_Enseignent.UseVisualStyleBackColor = false;
            this.btn_Enseignent.Click += new System.EventHandler(this.btn_Enseignent_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Enseignent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStagiaire, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEpreuve, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGroupes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1773, 586);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PFF_GEFA_TDI.Properties.Resources.e0813;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1083, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(492, 76);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gestion des utilisateurs";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // R_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1773, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "R_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R_Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.R_Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Enseignent;
        private System.Windows.Forms.Button btnGroupes;
        private System.Windows.Forms.Button btnSalles;
        private System.Windows.Forms.Button btnStagiaire;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnEpreuve;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}