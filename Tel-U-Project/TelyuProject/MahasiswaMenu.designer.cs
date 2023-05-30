namespace TelyuProject
{
    partial class MahasiswaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MahasiswaMenu));
            this.panelAtas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.JoinProject = new System.Windows.Forms.Button();
            this.panelKiri = new System.Windows.Forms.Panel();
            this.panelMyProject = new System.Windows.Forms.Panel();
            this.logoMyProjectDed = new System.Windows.Forms.PictureBox();
            this.labelMyProject = new System.Windows.Forms.Label();
            this.panelListProject = new System.Windows.Forms.Panel();
            this.LogoListProjectDed = new System.Windows.Forms.PictureBox();
            this.labelListProject = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Explore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LogoMyProjectActive = new System.Windows.Forms.PictureBox();
            this.LogoListProjectActive = new System.Windows.Forms.PictureBox();
            this.panelAtas.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelKiri.SuspendLayout();
            this.panelMyProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMyProjectDed)).BeginInit();
            this.panelListProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectDed)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMyProjectActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectActive)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.panelAtas.Controls.Add(this.label1);
            this.panelAtas.Location = new System.Drawing.Point(263, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1002, 68);
            this.panelAtas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(435, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel-U Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.JoinProject);
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.panelMain.Location = new System.Drawing.Point(265, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1000, 612);
            this.panelMain.TabIndex = 27;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(58, 54);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(872, 438);
            this.panelContent.TabIndex = 14;
            // 
            // JoinProject
            // 
            this.JoinProject.BackColor = System.Drawing.Color.AliceBlue;
            this.JoinProject.Font = new System.Drawing.Font("Poppins", 12F);
            this.JoinProject.Location = new System.Drawing.Point(385, 512);
            this.JoinProject.Margin = new System.Windows.Forms.Padding(2);
            this.JoinProject.Name = "JoinProject";
            this.JoinProject.Size = new System.Drawing.Size(224, 55);
            this.JoinProject.TabIndex = 13;
            this.JoinProject.Text = "Join Project";
            this.JoinProject.UseVisualStyleBackColor = false;
            this.JoinProject.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelKiri
            // 
            this.panelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.panelKiri.Controls.Add(this.panelMyProject);
            this.panelKiri.Controls.Add(this.panelListProject);
            this.panelKiri.Controls.Add(this.button2);
            this.panelKiri.Controls.Add(this.Explore);
            this.panelKiri.Controls.Add(this.panel2);
            this.panelKiri.Location = new System.Drawing.Point(-2, 0);
            this.panelKiri.Name = "panelKiri";
            this.panelKiri.Size = new System.Drawing.Size(266, 682);
            this.panelKiri.TabIndex = 25;
            this.panelKiri.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKiri_Paint);
            // 
            // panelMyProject
            // 
            this.panelMyProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(93)))));
            this.panelMyProject.Controls.Add(this.LogoMyProjectActive);
            this.panelMyProject.Controls.Add(this.logoMyProjectDed);
            this.panelMyProject.Controls.Add(this.labelMyProject);
            this.panelMyProject.Location = new System.Drawing.Point(21, 312);
            this.panelMyProject.Margin = new System.Windows.Forms.Padding(2);
            this.panelMyProject.Name = "panelMyProject";
            this.panelMyProject.Size = new System.Drawing.Size(224, 50);
            this.panelMyProject.TabIndex = 30;
            this.panelMyProject.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMyP_Paint);
            // 
            // logoMyProjectDed
            // 
            this.logoMyProjectDed.Image = global::TelyuProject.Properties.Resources.myProjectDed;
            this.logoMyProjectDed.Location = new System.Drawing.Point(15, 6);
            this.logoMyProjectDed.Margin = new System.Windows.Forms.Padding(2);
            this.logoMyProjectDed.Name = "logoMyProjectDed";
            this.logoMyProjectDed.Size = new System.Drawing.Size(29, 39);
            this.logoMyProjectDed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoMyProjectDed.TabIndex = 28;
            this.logoMyProjectDed.TabStop = false;
            // 
            // labelMyProject
            // 
            this.labelMyProject.AutoSize = true;
            this.labelMyProject.BackColor = System.Drawing.Color.Transparent;
            this.labelMyProject.Font = new System.Drawing.Font("Poppins", 12F);
            this.labelMyProject.ForeColor = System.Drawing.Color.White;
            this.labelMyProject.Location = new System.Drawing.Point(55, 12);
            this.labelMyProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyProject.Name = "labelMyProject";
            this.labelMyProject.Size = new System.Drawing.Size(94, 28);
            this.labelMyProject.TabIndex = 0;
            this.labelMyProject.Text = "My Project";
            this.labelMyProject.Click += new System.EventHandler(this.labelMyProject_Click);
            // 
            // panelListProject
            // 
            this.panelListProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.panelListProject.Controls.Add(this.LogoListProjectActive);
            this.panelListProject.Controls.Add(this.LogoListProjectDed);
            this.panelListProject.Controls.Add(this.labelListProject);
            this.panelListProject.Location = new System.Drawing.Point(21, 248);
            this.panelListProject.Margin = new System.Windows.Forms.Padding(2);
            this.panelListProject.Name = "panelListProject";
            this.panelListProject.Size = new System.Drawing.Size(224, 50);
            this.panelListProject.TabIndex = 27;
            this.panelListProject.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListProject_Paint_1);
            // 
            // LogoListProjectDed
            // 
            this.LogoListProjectDed.Image = global::TelyuProject.Properties.Resources.listDed;
            this.LogoListProjectDed.Location = new System.Drawing.Point(15, 6);
            this.LogoListProjectDed.Margin = new System.Windows.Forms.Padding(2);
            this.LogoListProjectDed.Name = "LogoListProjectDed";
            this.LogoListProjectDed.Size = new System.Drawing.Size(29, 39);
            this.LogoListProjectDed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoListProjectDed.TabIndex = 28;
            this.LogoListProjectDed.TabStop = false;
            // 
            // labelListProject
            // 
            this.labelListProject.AutoSize = true;
            this.labelListProject.BackColor = System.Drawing.Color.Transparent;
            this.labelListProject.Font = new System.Drawing.Font("Poppins", 12F);
            this.labelListProject.ForeColor = System.Drawing.Color.White;
            this.labelListProject.Location = new System.Drawing.Point(55, 12);
            this.labelListProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListProject.Name = "labelListProject";
            this.labelListProject.Size = new System.Drawing.Size(96, 28);
            this.labelListProject.TabIndex = 0;
            this.labelListProject.Text = "List Project";
            this.labelListProject.Click += new System.EventHandler(this.labelListProject_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(77, 591);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Explore
            // 
            this.Explore.AutoSize = true;
            this.Explore.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Explore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Explore.Location = new System.Drawing.Point(36, 193);
            this.Explore.Name = "Explore";
            this.Explore.Size = new System.Drawing.Size(95, 37);
            this.Explore.TabIndex = 18;
            this.Explore.Text = "Explore";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 162);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelyuProject.Properties.Resources.userDed;
            this.pictureBox1.Location = new System.Drawing.Point(104, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(2, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zaky";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // LogoMyProjectActive
            // 
            this.LogoMyProjectActive.Image = ((System.Drawing.Image)(resources.GetObject("LogoMyProjectActive.Image")));
            this.LogoMyProjectActive.Location = new System.Drawing.Point(15, 6);
            this.LogoMyProjectActive.Margin = new System.Windows.Forms.Padding(2);
            this.LogoMyProjectActive.Name = "LogoMyProjectActive";
            this.LogoMyProjectActive.Size = new System.Drawing.Size(29, 39);
            this.LogoMyProjectActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMyProjectActive.TabIndex = 29;
            this.LogoMyProjectActive.TabStop = false;
            // 
            // LogoListProjectActive
            // 
            this.LogoListProjectActive.Image = ((System.Drawing.Image)(resources.GetObject("LogoListProjectActive.Image")));
            this.LogoListProjectActive.Location = new System.Drawing.Point(15, 6);
            this.LogoListProjectActive.Margin = new System.Windows.Forms.Padding(2);
            this.LogoListProjectActive.Name = "LogoListProjectActive";
            this.LogoListProjectActive.Size = new System.Drawing.Size(29, 39);
            this.LogoListProjectActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoListProjectActive.TabIndex = 29;
            this.LogoListProjectActive.TabStop = false;
            // 
            // MahasiswaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelKiri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MahasiswaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MahasiswaMenu";
            this.Load += new System.EventHandler(this.MahasiswaMenu_Load);
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelKiri.ResumeLayout(false);
            this.panelKiri.PerformLayout();
            this.panelMyProject.ResumeLayout(false);
            this.panelMyProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMyProjectDed)).EndInit();
            this.panelListProject.ResumeLayout(false);
            this.panelListProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectDed)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMyProjectActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panelKiri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Explore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button JoinProject;
        private System.Windows.Forms.Panel panelListProject;
        private System.Windows.Forms.PictureBox LogoListProjectDed;
        private System.Windows.Forms.Label labelListProject;
        private System.Windows.Forms.Panel panelMyProject;
        private System.Windows.Forms.PictureBox logoMyProjectDed;
        private System.Windows.Forms.Label labelMyProject;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox LogoMyProjectActive;
        private System.Windows.Forms.PictureBox LogoListProjectActive;
    }
}