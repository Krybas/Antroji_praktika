namespace Praktika
{
    partial class prideti_destytoja
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prideti_dest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pridėti dėstytoją";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dėstytojo ID:";
            // 
            // txtDID
            // 
            this.txtDID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtDID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtDID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtDID.Location = new System.Drawing.Point(12, 64);
            this.txtDID.Name = "txtDID";
            this.txtDID.ReadOnly = true;
            this.txtDID.Size = new System.Drawing.Size(220, 19);
            this.txtDID.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(16, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Iveskite dėstytojo vardą:";
            // 
            // txtDV
            // 
            this.txtDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtDV.Location = new System.Drawing.Point(16, 118);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(220, 19);
            this.txtDV.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel2.Location = new System.Drawing.Point(16, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Iveskite dėstytojo pavardę:";
            // 
            // txtDP
            // 
            this.txtDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.txtDP.Location = new System.Drawing.Point(16, 172);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(220, 19);
            this.txtDP.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.panel3.Location = new System.Drawing.Point(16, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 3);
            this.panel3.TabIndex = 11;
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
            this.prideti_dest.Location = new System.Drawing.Point(12, 206);
            this.prideti_dest.Name = "prideti_dest";
            this.prideti_dest.Size = new System.Drawing.Size(225, 57);
            this.prideti_dest.TabIndex = 19;
            this.prideti_dest.Text = "Pridėti";
            this.prideti_dest.UseVisualStyleBackColor = false;
            this.prideti_dest.Click += new System.EventHandler(this.prideti_stud_Click);
            // 
            // prideti_destytoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(259, 274);
            this.Controls.Add(this.prideti_dest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "prideti_destytoja";
            this.Text = "prideti_destytoja";
            this.Load += new System.EventHandler(this.prideti_destytoja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button prideti_dest;
    }
}