namespace Praktika
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Prisijungimas = new System.Windows.Forms.Label();
            this.VartotojoVardas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Prisijungti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pasirinkimas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prisijungimas
            // 
            this.Prisijungimas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Prisijungimas.BackColor = System.Drawing.Color.Transparent;
            this.Prisijungimas.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Prisijungimas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.Prisijungimas.Location = new System.Drawing.Point(26, 175);
            this.Prisijungimas.Name = "Prisijungimas";
            this.Prisijungimas.Size = new System.Drawing.Size(225, 30);
            this.Prisijungimas.TabIndex = 0;
            this.Prisijungimas.Text = "Prisijungimas";
            this.Prisijungimas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Prisijungimas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // VartotojoVardas
            // 
            this.VartotojoVardas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VartotojoVardas.BackColor = System.Drawing.Color.Transparent;
            this.VartotojoVardas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.VartotojoVardas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.VartotojoVardas.Location = new System.Drawing.Point(26, 338);
            this.VartotojoVardas.Name = "VartotojoVardas";
            this.VartotojoVardas.Size = new System.Drawing.Size(221, 24);
            this.VartotojoVardas.TabIndex = 1;
            this.VartotojoVardas.Text = "Vartotojo vardas:";
            this.VartotojoVardas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VartotojoVardas.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(31, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel2.Location = new System.Drawing.Point(31, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(27, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Slaptažodis:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtUsername.Location = new System.Drawing.Point(31, 365);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 19);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtPassword.Location = new System.Drawing.Point(31, 423);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 19);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // Prisijungti
            // 
            this.Prisijungti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.Prisijungti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Prisijungti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Prisijungti.FlatAppearance.BorderSize = 0;
            this.Prisijungti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prisijungti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Prisijungti.ForeColor = System.Drawing.Color.White;
            this.Prisijungti.Location = new System.Drawing.Point(30, 488);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(257, 57);
            this.Prisijungti.TabIndex = 9;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = false;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(26, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pasirinkti:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Pasirinkimas
            // 
            this.Pasirinkimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Pasirinkimas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.Pasirinkimas.FormattingEnabled = true;
            this.Pasirinkimas.Items.AddRange(new object[] {
            "Studentas",
            "Dėstytojas",
            "Administratorius"});
            this.Pasirinkimas.Location = new System.Drawing.Point(31, 253);
            this.Pasirinkimas.Name = "Pasirinkimas";
            this.Pasirinkimas.Size = new System.Drawing.Size(160, 28);
            this.Pasirinkimas.TabIndex = 11;
            this.Pasirinkimas.SelectedIndexChanged += new System.EventHandler(this.Pasirinkimas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(318, 592);
            this.Controls.Add(this.Pasirinkimas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prisijungti);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VartotojoVardas);
            this.Controls.Add(this.Prisijungimas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacijos sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prisijungimas;
        private System.Windows.Forms.Label VartotojoVardas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Pasirinkimas;
    }
}

