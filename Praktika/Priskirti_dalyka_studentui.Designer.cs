namespace Praktika
{
    partial class Priskirti_dalyka_studentui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSDID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prideti_dest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Priskirtų dalykų studentui sąrašas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(495, 380);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(599, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pridėti į sąrašą";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(535, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Studento dalyko ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(539, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 3);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(535, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Įveskite dalyko ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDID
            // 
            this.txtDID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtDID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtDID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtDID.Location = new System.Drawing.Point(539, 142);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(221, 19);
            this.txtDID.TabIndex = 14;
            this.txtDID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel2.Location = new System.Drawing.Point(539, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 3);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtSDID
            // 
            this.txtSDID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtSDID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtSDID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtSDID.Location = new System.Drawing.Point(539, 88);
            this.txtSDID.Name = "txtSDID";
            this.txtSDID.ReadOnly = true;
            this.txtSDID.Size = new System.Drawing.Size(220, 19);
            this.txtSDID.TabIndex = 16;
            this.txtSDID.TextChanged += new System.EventHandler(this.txtDID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(535, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Įveskite studento ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSID
            // 
            this.txtSID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtSID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtSID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtSID.Location = new System.Drawing.Point(539, 196);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(221, 19);
            this.txtSID.TabIndex = 18;
            this.txtSID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel3.Location = new System.Drawing.Point(539, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 3);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // prideti_dest
            // 
            this.prideti_dest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.prideti_dest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prideti_dest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.prideti_dest.FlatAppearance.BorderSize = 0;
            this.prideti_dest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prideti_dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.prideti_dest.ForeColor = System.Drawing.Color.White;
            this.prideti_dest.Location = new System.Drawing.Point(539, 230);
            this.prideti_dest.Name = "prideti_dest";
            this.prideti_dest.Size = new System.Drawing.Size(252, 57);
            this.prideti_dest.TabIndex = 21;
            this.prideti_dest.Text = "Pridėti";
            this.prideti_dest.UseVisualStyleBackColor = false;
            this.prideti_dest.Click += new System.EventHandler(this.prideti_dest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(599, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pašalinti iš sąrašo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(535, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Studento dalyko ID:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.textBox1.Location = new System.Drawing.Point(539, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 19);
            this.textBox1.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel4.Location = new System.Drawing.Point(539, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 3);
            this.panel4.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(539, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 57);
            this.button2.TabIndex = 25;
            this.button2.Text = "Ištrinti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Priskirti_dalyka_studentui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(837, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prideti_dest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSDID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Priskirti_dalyka_studentui";
            this.Text = "Priskirti_dalyka_studentui";
            this.Load += new System.EventHandler(this.Priskirti_dalyka_studentui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSDID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button prideti_dest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
    }
}