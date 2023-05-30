namespace TelyuProject
{
    partial class SignUpDosen
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
            this.LBack = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RGenderFemale = new System.Windows.Forms.RadioButton();
            this.RGenderM = new System.Windows.Forms.RadioButton();
            this.LGender = new System.Windows.Forms.Label();
            this.BMajor = new System.Windows.Forms.ComboBox();
            this.LMajor = new System.Windows.Forms.Label();
            this.BFaculty = new System.Windows.Forms.ComboBox();
            this.LFaculty = new System.Windows.Forms.Label();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.Lphone = new System.Windows.Forms.Label();
            this.TEmployeeID = new System.Windows.Forms.TextBox();
            this.LEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TLecCode = new System.Windows.Forms.TextBox();
            this.LLecCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBack
            // 
            this.LBack.AutoSize = true;
            this.LBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBack.Location = new System.Drawing.Point(32, 27);
            this.LBack.Name = "LBack";
            this.LBack.Size = new System.Drawing.Size(95, 25);
            this.LBack.TabIndex = 47;
            this.LBack.Text = "<-- Back";
            this.LBack.Click += new System.EventHandler(this.LBack_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(372, 490);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(507, 58);
            this.LoginButton.TabIndex = 46;
            this.LoginButton.Text = "Submit";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RGenderFemale
            // 
            this.RGenderFemale.AutoSize = true;
            this.RGenderFemale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGenderFemale.Location = new System.Drawing.Point(732, 414);
            this.RGenderFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RGenderFemale.Name = "RGenderFemale";
            this.RGenderFemale.Size = new System.Drawing.Size(91, 28);
            this.RGenderFemale.TabIndex = 45;
            this.RGenderFemale.TabStop = true;
            this.RGenderFemale.Text = "Female";
            this.RGenderFemale.UseVisualStyleBackColor = true;
            // 
            // RGenderM
            // 
            this.RGenderM.AutoSize = true;
            this.RGenderM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGenderM.Location = new System.Drawing.Point(637, 414);
            this.RGenderM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RGenderM.Name = "RGenderM";
            this.RGenderM.Size = new System.Drawing.Size(73, 28);
            this.RGenderM.TabIndex = 44;
            this.RGenderM.TabStop = true;
            this.RGenderM.Text = "Male";
            this.RGenderM.UseVisualStyleBackColor = true;
            // 
            // LGender
            // 
            this.LGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LGender.Location = new System.Drawing.Point(635, 382);
            this.LGender.Name = "LGender";
            this.LGender.Size = new System.Drawing.Size(260, 25);
            this.LGender.TabIndex = 43;
            this.LGender.Text = "Gender";
            this.LGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BMajor
            // 
            this.BMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BMajor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BMajor.Location = new System.Drawing.Point(637, 330);
            this.BMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BMajor.Name = "BMajor";
            this.BMajor.Size = new System.Drawing.Size(240, 29);
            this.BMajor.TabIndex = 42;
            // 
            // LMajor
            // 
            this.LMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMajor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LMajor.Location = new System.Drawing.Point(635, 303);
            this.LMajor.Name = "LMajor";
            this.LMajor.Size = new System.Drawing.Size(260, 25);
            this.LMajor.TabIndex = 41;
            this.LMajor.Text = "Major";
            this.LMajor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BFaculty
            // 
            this.BFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BFaculty.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFaculty.FormattingEnabled = true;
            this.BFaculty.Items.AddRange(new object[] {
            "Fakultas Teknik Elektro. ",
            "Fakultas Rekayasa Industri. ",
            "Fakultas Informatika.",
            "Fakultas Ekonomi dan Bisnis. ",
            "Fakultas Komunikasi dan Bisnis. ",
            "Fakultas Industri Kreatif. ",
            "Fakultas Ilmu Terapan"});
            this.BFaculty.Location = new System.Drawing.Point(372, 330);
            this.BFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BFaculty.Name = "BFaculty";
            this.BFaculty.Size = new System.Drawing.Size(240, 29);
            this.BFaculty.TabIndex = 40;
            // 
            // LFaculty
            // 
            this.LFaculty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LFaculty.Location = new System.Drawing.Point(368, 303);
            this.LFaculty.Name = "LFaculty";
            this.LFaculty.Size = new System.Drawing.Size(260, 25);
            this.LFaculty.TabIndex = 39;
            this.LFaculty.Text = "Faculty";
            this.LFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TPhone
            // 
            this.TPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPhone.Location = new System.Drawing.Point(637, 247);
            this.TPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(240, 34);
            this.TPhone.TabIndex = 38;
            this.TPhone.TextChanged += new System.EventHandler(this.TPhone_TextChanged);
            this.TPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPhone_KeyPress);
            // 
            // Lphone
            // 
            this.Lphone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lphone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lphone.Location = new System.Drawing.Point(635, 222);
            this.Lphone.Name = "Lphone";
            this.Lphone.Size = new System.Drawing.Size(260, 25);
            this.Lphone.TabIndex = 37;
            this.Lphone.Text = "Phone number";
            this.Lphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TEmployeeID
            // 
            this.TEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmployeeID.Location = new System.Drawing.Point(372, 247);
            this.TEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TEmployeeID.Name = "TEmployeeID";
            this.TEmployeeID.Size = new System.Drawing.Size(240, 34);
            this.TEmployeeID.TabIndex = 36;
            this.TEmployeeID.TextChanged += new System.EventHandler(this.TEmployeeID_TextChanged);
            this.TEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TEmployeeID_KeyPress);
            // 
            // LEmployeeID
            // 
            this.LEmployeeID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmployeeID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LEmployeeID.Location = new System.Drawing.Point(368, 222);
            this.LEmployeeID.Name = "LEmployeeID";
            this.LEmployeeID.Size = new System.Drawing.Size(260, 25);
            this.LEmployeeID.TabIndex = 35;
            this.LEmployeeID.Text = "Employee ID";
            this.LEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LEmployeeID.Click += new System.EventHandler(this.Lnim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 34;
            this.label1.Text = "Personal Data";
            // 
            // TLecCode
            // 
            this.TLecCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TLecCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLecCode.Location = new System.Drawing.Point(372, 407);
            this.TLecCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TLecCode.Name = "TLecCode";
            this.TLecCode.Size = new System.Drawing.Size(240, 34);
            this.TLecCode.TabIndex = 49;
            // 
            // LLecCode
            // 
            this.LLecCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLecCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LLecCode.Location = new System.Drawing.Point(368, 382);
            this.LLecCode.Name = "LLecCode";
            this.LLecCode.Size = new System.Drawing.Size(260, 25);
            this.LLecCode.TabIndex = 48;
            this.LLecCode.Text = "Lecturer Code";
            this.LLecCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SignUpDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.TLecCode);
            this.Controls.Add(this.LLecCode);
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
            this.Controls.Add(this.TEmployeeID);
            this.Controls.Add(this.LEmployeeID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUpDosen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpDosen";
            this.Load += new System.EventHandler(this.SignUpDosen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBack;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.RadioButton RGenderFemale;
        private System.Windows.Forms.RadioButton RGenderM;
        private System.Windows.Forms.Label LGender;
        private System.Windows.Forms.ComboBox BMajor;
        private System.Windows.Forms.Label LMajor;
        private System.Windows.Forms.ComboBox BFaculty;
        private System.Windows.Forms.Label LFaculty;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Label Lphone;
        private System.Windows.Forms.TextBox TEmployeeID;
        private System.Windows.Forms.Label LEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TLecCode;
        private System.Windows.Forms.Label LLecCode;
    }
}