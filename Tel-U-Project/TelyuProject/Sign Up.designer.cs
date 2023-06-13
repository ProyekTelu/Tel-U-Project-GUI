namespace TelyuProject
{
    partial class Sign_Up
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LFirstname = new System.Windows.Forms.Label();
            this.TFirstName = new System.Windows.Forms.TextBox();
            this.TLastName = new System.Windows.Forms.TextBox();
            this.LLastName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(548, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 49);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tel-U Project";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(548, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LPassword
            // 
            this.LPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LPassword.Location = new System.Drawing.Point(399, 435);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(292, 31);
            this.LPassword.TabIndex = 14;
            this.LPassword.Text = "Password";
            this.LPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LEmail
            // 
            this.LEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LEmail.Location = new System.Drawing.Point(399, 342);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(292, 31);
            this.LEmail.TabIndex = 13;
            this.LEmail.Text = "Email";
            this.LEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TEmail
            // 
            this.TEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TEmail.Location = new System.Drawing.Point(402, 374);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(586, 27);
            this.TEmail.TabIndex = 12;
            this.TEmail.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(405, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 103);
            this.label2.TabIndex = 11;
            this.label2.Text = "Silakan gunakan username@telkomuniversity.ac.id sesuai iGracias Telkom University" +
    " untuk TPA/Dosen dan username@student.telkomuniversity.ac.id untuk Mahasiswa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TPassword
            // 
            this.TPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TPassword.Location = new System.Drawing.Point(402, 468);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(588, 27);
            this.TPassword.TabIndex = 10;
            this.TPassword.UseSystemPasswordChar = true;
            this.TPassword.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(406, 585);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(586, 72);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Sign-Up";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LFirstname
            // 
            this.LFirstname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFirstname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFirstname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LFirstname.Location = new System.Drawing.Point(399, 263);
            this.LFirstname.Name = "LFirstname";
            this.LFirstname.Size = new System.Drawing.Size(292, 31);
            this.LFirstname.TabIndex = 18;
            this.LFirstname.Text = "First Name";
            this.LFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TFirstName
            // 
            this.TFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TFirstName.Location = new System.Drawing.Point(402, 297);
            this.TFirstName.Name = "TFirstName";
            this.TFirstName.Size = new System.Drawing.Size(270, 27);
            this.TFirstName.TabIndex = 19;
            this.TFirstName.TextChanged += new System.EventHandler(this.TFirstName_TextChanged);
            // 
            // TLastName
            // 
            this.TLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TLastName.Location = new System.Drawing.Point(717, 297);
            this.TLastName.Name = "TLastName";
            this.TLastName.Size = new System.Drawing.Size(271, 27);
            this.TLastName.TabIndex = 21;
            this.TLastName.TextChanged += new System.EventHandler(this.TLastName_TextChanged);
            // 
            // LLastName
            // 
            this.LLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LLastName.Location = new System.Drawing.Point(712, 263);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(292, 31);
            this.LLastName.TabIndex = 20;
            this.LLastName.Text = "Last Name";
            this.LLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LLastName.Click += new System.EventHandler(this.label8_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.Location = new System.Drawing.Point(404, 549);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sudah Punya Akun? Sign In?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1419, 842);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TLastName);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.TFirstName);
            this.Controls.Add(this.LFirstname);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_Up";
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LFirstname;
        private System.Windows.Forms.TextBox TFirstName;
        private System.Windows.Forms.TextBox TLastName;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}