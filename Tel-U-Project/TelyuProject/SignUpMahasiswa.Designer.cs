namespace TelyuProject
{
    partial class SignUpMahasiswa
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
            this.TStudentID = new System.Windows.Forms.TextBox();
            this.Lnim = new System.Windows.Forms.Label();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.Lphone = new System.Windows.Forms.Label();
            this.LFaculty = new System.Windows.Forms.Label();
            this.BFaculty = new System.Windows.Forms.ComboBox();
            this.BMajor = new System.Windows.Forms.ComboBox();
            this.LMajor = new System.Windows.Forms.Label();
            this.LGender = new System.Windows.Forms.Label();
            this.RGenderM = new System.Windows.Forms.RadioButton();
            this.RGenderFemale = new System.Windows.Forms.RadioButton();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Data";
            // 
            // TStudentID
            // 
            this.TStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TStudentID.ForeColor = System.Drawing.Color.Black;
            this.TStudentID.Location = new System.Drawing.Point(280, 201);
            this.TStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TStudentID.Name = "TStudentID";
            this.TStudentID.Size = new System.Drawing.Size(181, 29);
            this.TStudentID.TabIndex = 21;
            this.TStudentID.TextChanged += new System.EventHandler(this.TStudentID_TextChanged);
            this.TStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TStudentID_KeyPress);
            // 
            // Lnim
            // 
            this.Lnim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnim.ForeColor = System.Drawing.Color.White;
            this.Lnim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lnim.Location = new System.Drawing.Point(276, 180);
            this.Lnim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lnim.Name = "Lnim";
            this.Lnim.Size = new System.Drawing.Size(195, 20);
            this.Lnim.TabIndex = 20;
            this.Lnim.Text = "Student ID";
            this.Lnim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TPhone
            // 
            this.TPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPhone.ForeColor = System.Drawing.Color.Black;
            this.TPhone.Location = new System.Drawing.Point(478, 201);
            this.TPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(181, 29);
            this.TPhone.TabIndex = 23;
            this.TPhone.TextChanged += new System.EventHandler(this.TPhone_TextChanged);
            this.TPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPhone_KeyPress);
            // 
            // Lphone
            // 
            this.Lphone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lphone.ForeColor = System.Drawing.Color.White;
            this.Lphone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lphone.Location = new System.Drawing.Point(476, 180);
            this.Lphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lphone.Name = "Lphone";
            this.Lphone.Size = new System.Drawing.Size(195, 20);
            this.Lphone.TabIndex = 22;
            this.Lphone.Text = "Phone number";
            this.Lphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LFaculty
            // 
            this.LFaculty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFaculty.ForeColor = System.Drawing.Color.White;
            this.LFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LFaculty.Location = new System.Drawing.Point(276, 246);
            this.LFaculty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFaculty.Name = "LFaculty";
            this.LFaculty.Size = new System.Drawing.Size(195, 20);
            this.LFaculty.TabIndex = 24;
            this.LFaculty.Text = "Faculty";
            this.LFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BFaculty
            // 
            this.BFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BFaculty.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFaculty.ForeColor = System.Drawing.Color.Black;
            this.BFaculty.FormattingEnabled = true;
            this.BFaculty.Items.AddRange(new object[] {
            "Fakultas Teknik Elektro. ",
            "Fakultas Rekayasa Industri. ",
            "Fakultas Informatika.",
            "Fakultas Ekonomi dan Bisnis. ",
            "Fakultas Komunikasi dan Bisnis. ",
            "Fakultas Industri Kreatif. ",
            "Fakultas Ilmu Terapan"});
            this.BFaculty.Location = new System.Drawing.Point(279, 268);
            this.BFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BFaculty.Name = "BFaculty";
            this.BFaculty.Size = new System.Drawing.Size(181, 24);
            this.BFaculty.TabIndex = 25;
            this.BFaculty.SelectedIndexChanged += new System.EventHandler(this.BFaculty_SelectedIndexChanged);
            // 
            // BMajor
            // 
            this.BMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BMajor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMajor.ForeColor = System.Drawing.Color.Black;
            this.BMajor.FormattingEnabled = true;
            this.BMajor.Items.AddRange(new object[] {
            "S1 Teknik Elektro",
            "S1 Teknik Elektro (International Class)",
            "S1 Teknik Telekomunikasi",
            "S1 Smart Science and Technology",
            "S1 Teknik Biomedis",
            "S1 Ilmu Komunikasi",
            "S1 Administrasi Bisnis",
            "S1 Creative Arts",
            "S1 Teknik Industri",
            "S1 Rekayasa Perangkat Lunak",
            "S1 Informatika",
            "S1 Data Science",
            "S1 Akutansi",
            "S1 Sistem Informasi",
            "S1 Leisure Management",
            "S1 Kriya",
            "D3 Digital Marketing"});
            this.BMajor.Location = new System.Drawing.Point(478, 268);
            this.BMajor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BMajor.Name = "BMajor";
            this.BMajor.Size = new System.Drawing.Size(181, 24);
            this.BMajor.TabIndex = 27;
            this.BMajor.SelectedIndexChanged += new System.EventHandler(this.BMajor_SelectedIndexChanged);
            // 
            // LMajor
            // 
            this.LMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMajor.ForeColor = System.Drawing.Color.White;
            this.LMajor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LMajor.Location = new System.Drawing.Point(476, 246);
            this.LMajor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMajor.Name = "LMajor";
            this.LMajor.Size = new System.Drawing.Size(195, 20);
            this.LMajor.TabIndex = 26;
            this.LMajor.Text = "Major";
            this.LMajor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LGender
            // 
            this.LGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGender.ForeColor = System.Drawing.Color.White;
            this.LGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LGender.Location = new System.Drawing.Point(276, 313);
            this.LGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LGender.Name = "LGender";
            this.LGender.Size = new System.Drawing.Size(195, 20);
            this.LGender.TabIndex = 28;
            this.LGender.Text = "Gender";
            this.LGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RGenderM
            // 
            this.RGenderM.AutoSize = true;
            this.RGenderM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGenderM.ForeColor = System.Drawing.Color.White;
            this.RGenderM.Location = new System.Drawing.Point(281, 335);
            this.RGenderM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RGenderM.Name = "RGenderM";
            this.RGenderM.Size = new System.Drawing.Size(60, 23);
            this.RGenderM.TabIndex = 29;
            this.RGenderM.TabStop = true;
            this.RGenderM.Text = "Male";
            this.RGenderM.UseVisualStyleBackColor = true;
            this.RGenderM.CheckedChanged += new System.EventHandler(this.RGenderM_CheckedChanged);
            // 
            // RGenderFemale
            // 
            this.RGenderFemale.AutoSize = true;
            this.RGenderFemale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGenderFemale.ForeColor = System.Drawing.Color.White;
            this.RGenderFemale.Location = new System.Drawing.Point(352, 335);
            this.RGenderFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RGenderFemale.Name = "RGenderFemale";
            this.RGenderFemale.Size = new System.Drawing.Size(74, 23);
            this.RGenderFemale.TabIndex = 30;
            this.RGenderFemale.TabStop = true;
            this.RGenderFemale.Text = "Female";
            this.RGenderFemale.UseVisualStyleBackColor = true;
            this.RGenderFemale.CheckedChanged += new System.EventHandler(this.RGenderFemale_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(279, 398);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(380, 47);
            this.LoginButton.TabIndex = 32;
            this.LoginButton.Text = "Submit";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LBack
            // 
            this.LBack.AutoSize = true;
            this.LBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBack.ForeColor = System.Drawing.Color.White;
            this.LBack.Location = new System.Drawing.Point(24, 24);
            this.LBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBack.Name = "LBack";
            this.LBack.Size = new System.Drawing.Size(76, 20);
            this.LBack.TabIndex = 33;
            this.LBack.Text = "<-- Back";
            this.LBack.Click += new System.EventHandler(this.LBack_Click);
            // 
            // SignUpMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.LBack);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RGenderFemale);
            this.Controls.Add(this.RGenderM);
            this.Controls.Add(this.LGender);
            this.Controls.Add(this.BMajor);
            this.Controls.Add(this.LMajor);
            this.Controls.Add(this.BFaculty);
            this.Controls.Add(this.LFaculty);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.Lphone);
            this.Controls.Add(this.TStudentID);
            this.Controls.Add(this.Lnim);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUpMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpMahasiswa";
            this.Load += new System.EventHandler(this.SignUpMahasiswa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TStudentID;
        private System.Windows.Forms.Label Lnim;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Label Lphone;
        private System.Windows.Forms.Label LFaculty;
        private System.Windows.Forms.ComboBox BFaculty;
        private System.Windows.Forms.ComboBox BMajor;
        private System.Windows.Forms.Label LMajor;
        private System.Windows.Forms.Label LGender;
        private System.Windows.Forms.RadioButton RGenderM;
        private System.Windows.Forms.RadioButton RGenderFemale;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LBack;
    }
}