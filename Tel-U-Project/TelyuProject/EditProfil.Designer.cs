namespace TelyuProject
{
    partial class EditProfil
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
            this.TitleForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditFirstName = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.Label();
            this.EditLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditSkill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EditLookingFor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProfilEmail = new System.Windows.Forms.Label();
            this.EditProfilEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "<-- Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleForm
            // 
            this.TitleForm.AutoSize = true;
            this.TitleForm.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleForm.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleForm.Location = new System.Drawing.Point(264, 0);
            this.TitleForm.Name = "TitleForm";
            this.TitleForm.Size = new System.Drawing.Size(93, 41);
            this.TitleForm.TabIndex = 13;
            this.TitleForm.Text = "Profil";
            this.TitleForm.Click += new System.EventHandler(this.TitleForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 15;
            // 
            // EditFirstName
            // 
            this.EditFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFirstName.Location = new System.Drawing.Point(366, 147);
            this.EditFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditFirstName.Multiline = true;
            this.EditFirstName.Name = "EditFirstName";
            this.EditFirstName.ReadOnly = true;
            this.EditFirstName.Size = new System.Drawing.Size(531, 32);
            this.EditFirstName.TabIndex = 17;
            this.EditFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.Color.DarkGray;
            this.Nama.Location = new System.Drawing.Point(41, 74);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(134, 29);
            this.Nama.TabIndex = 16;
            this.Nama.Text = "First Name*";
            this.Nama.Click += new System.EventHandler(this.Nama_Click);
            // 
            // EditLastName
            // 
            this.EditLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLastName.Location = new System.Drawing.Point(44, 166);
            this.EditLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditLastName.Multiline = true;
            this.EditLastName.Name = "EditLastName";
            this.EditLastName.ReadOnly = true;
            this.EditLastName.Size = new System.Drawing.Size(531, 32);
            this.EditLastName.TabIndex = 19;
            this.EditLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(41, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name*";
            // 
            // EditStudentID
            // 
            this.EditStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStudentID.Location = new System.Drawing.Point(44, 231);
            this.EditStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditStudentID.Multiline = true;
            this.EditStudentID.Name = "EditStudentID";
            this.EditStudentID.ReadOnly = true;
            this.EditStudentID.Size = new System.Drawing.Size(531, 32);
            this.EditStudentID.TabIndex = 21;
            this.EditStudentID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(39, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Student ID*";
            // 
            // EditSkill
            // 
            this.EditSkill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSkill.Location = new System.Drawing.Point(44, 364);
            this.EditSkill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditSkill.Multiline = true;
            this.EditSkill.Name = "EditSkill";
            this.EditSkill.Size = new System.Drawing.Size(531, 32);
            this.EditSkill.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(43, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Skill";
            // 
            // EditLookingFor
            // 
            this.EditLookingFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditLookingFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLookingFor.Location = new System.Drawing.Point(44, 429);
            this.EditLookingFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditLookingFor.Multiline = true;
            this.EditLookingFor.Name = "EditLookingFor";
            this.EditLookingFor.Size = new System.Drawing.Size(531, 32);
            this.EditLookingFor.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(43, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Looking For";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(575, 569);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 58);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.labelProfilEmail);
            this.panel1.Controls.Add(this.EditStudentID);
            this.panel1.Controls.Add(this.EditProfilEmail);
            this.panel1.Controls.Add(this.EditLastName);
            this.panel1.Controls.Add(this.TitleForm);
            this.panel1.Controls.Add(this.EditSkill);
            this.panel1.Controls.Add(this.EditLookingFor);
            this.panel1.Controls.Add(this.Nama);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(322, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 599);
            this.panel1.TabIndex = 29;
            // 
            // labelProfilEmail
            // 
            this.labelProfilEmail.AutoSize = true;
            this.labelProfilEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfilEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.labelProfilEmail.Location = new System.Drawing.Point(41, 265);
            this.labelProfilEmail.Name = "labelProfilEmail";
            this.labelProfilEmail.Size = new System.Drawing.Size(168, 29);
            this.labelProfilEmail.TabIndex = 31;
            this.labelProfilEmail.Text = "Email Address*";
            // 
            // EditProfilEmail
            // 
            this.EditProfilEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditProfilEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProfilEmail.Location = new System.Drawing.Point(44, 296);
            this.EditProfilEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditProfilEmail.Multiline = true;
            this.EditProfilEmail.Name = "EditProfilEmail";
            this.EditProfilEmail.ReadOnly = true;
            this.EditProfilEmail.Size = new System.Drawing.Size(531, 32);
            this.EditProfilEmail.TabIndex = 30;
            // 
            // EditProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfil";
            this.Load += new System.EventHandler(this.EditProfil_Load);
            this.StyleChanged += new System.EventHandler(this.EditProfil_StyleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitleForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditFirstName;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.TextBox EditLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EditStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EditSkill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EditLookingFor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProfilEmail;
        private System.Windows.Forms.TextBox EditProfilEmail;
    }
}