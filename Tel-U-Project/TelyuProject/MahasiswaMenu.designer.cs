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
            this.panelKiri = new System.Windows.Forms.Panel();
            this.panelMyProject = new System.Windows.Forms.Panel();
            this.labelMyProject = new System.Windows.Forms.Label();
            this.panelListProject = new System.Windows.Forms.Panel();
            this.labelListProject = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Explore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.button1 = new System.Windows.Forms.Button();
            this.LogoMyProjectActive = new System.Windows.Forms.PictureBox();
            this.logoMyProjectDed = new System.Windows.Forms.PictureBox();
            this.LogoListProjectActive = new System.Windows.Forms.PictureBox();
            this.LogoListProjectDed = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelAtas.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelKiri.SuspendLayout();
            this.panelMyProject.SuspendLayout();
            this.panelListProject.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMyProjectActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMyProjectDed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectDed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.panelAtas.Controls.Add(this.label1);
            this.panelAtas.Location = new System.Drawing.Point(394, 0);
            this.panelAtas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1503, 105);
            this.panelAtas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(652, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel-U Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.panelMain.Location = new System.Drawing.Point(398, 108);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1500, 942);
            this.panelMain.TabIndex = 27;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(87, 38);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1308, 718);
            this.panelContent.TabIndex = 14;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint_1);
            // 
            // panelKiri
            // 
            this.panelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.panelKiri.Controls.Add(this.button1);
            this.panelKiri.Controls.Add(this.panelMyProject);
            this.panelKiri.Controls.Add(this.panelListProject);
            this.panelKiri.Controls.Add(this.button2);
            this.panelKiri.Controls.Add(this.Explore);
            this.panelKiri.Controls.Add(this.panel2);
            this.panelKiri.Location = new System.Drawing.Point(-3, 0);
            this.panelKiri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKiri.Name = "panelKiri";
            this.panelKiri.Size = new System.Drawing.Size(399, 1049);
            this.panelKiri.TabIndex = 25;
            this.panelKiri.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKiri_Paint);
            // 
            // panelMyProject
            // 
            this.panelMyProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(41)))), ((int)(((byte)(93)))));
            this.panelMyProject.Controls.Add(this.LogoMyProjectActive);
            this.panelMyProject.Controls.Add(this.logoMyProjectDed);
            this.panelMyProject.Controls.Add(this.labelMyProject);
            this.panelMyProject.Location = new System.Drawing.Point(32, 480);
            this.panelMyProject.Name = "panelMyProject";
            this.panelMyProject.Size = new System.Drawing.Size(336, 77);
            this.panelMyProject.TabIndex = 30;
            this.panelMyProject.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMyP_Paint);
            // 
            // labelMyProject
            // 
            this.labelMyProject.AutoSize = true;
            this.labelMyProject.BackColor = System.Drawing.Color.Transparent;
            this.labelMyProject.Font = new System.Drawing.Font("Poppins", 12F);
            this.labelMyProject.ForeColor = System.Drawing.Color.White;
            this.labelMyProject.Location = new System.Drawing.Point(82, 18);
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
            this.panelListProject.Location = new System.Drawing.Point(32, 382);
            this.panelListProject.Name = "panelListProject";
            this.panelListProject.Size = new System.Drawing.Size(336, 77);
            this.panelListProject.TabIndex = 27;
            this.panelListProject.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListProject_Paint_1);
            // 
            // labelListProject
            // 
            this.labelListProject.AutoSize = true;
            this.labelListProject.BackColor = System.Drawing.Color.Transparent;
            this.labelListProject.Font = new System.Drawing.Font("Poppins", 12F);
            this.labelListProject.ForeColor = System.Drawing.Color.White;
            this.labelListProject.Location = new System.Drawing.Point(82, 18);
            this.labelListProject.Name = "labelListProject";
            this.labelListProject.Size = new System.Drawing.Size(96, 28);
            this.labelListProject.TabIndex = 0;
            this.labelListProject.Text = "List Project";
            this.labelListProject.Click += new System.EventHandler(this.labelListProject_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(116, 909);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 52);
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
            this.Explore.Location = new System.Drawing.Point(54, 297);
            this.Explore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 249);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zaky";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(61, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 52);
            this.button1.TabIndex = 21;
            this.button1.Text = "You have no invitation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogoMyProjectActive
            // 
            this.LogoMyProjectActive.Image = ((System.Drawing.Image)(resources.GetObject("LogoMyProjectActive.Image")));
            this.LogoMyProjectActive.Location = new System.Drawing.Point(22, 9);
            this.LogoMyProjectActive.Name = "LogoMyProjectActive";
            this.LogoMyProjectActive.Size = new System.Drawing.Size(44, 60);
            this.LogoMyProjectActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMyProjectActive.TabIndex = 29;
            this.LogoMyProjectActive.TabStop = false;
            // 
            // logoMyProjectDed
            // 
            this.logoMyProjectDed.Image = global::TelyuProject.Properties.Resources.myProjectDed;
            this.logoMyProjectDed.Location = new System.Drawing.Point(22, 9);
            this.logoMyProjectDed.Name = "logoMyProjectDed";
            this.logoMyProjectDed.Size = new System.Drawing.Size(44, 60);
            this.logoMyProjectDed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoMyProjectDed.TabIndex = 28;
            this.logoMyProjectDed.TabStop = false;
            // 
            // LogoListProjectActive
            // 
            this.LogoListProjectActive.Image = ((System.Drawing.Image)(resources.GetObject("LogoListProjectActive.Image")));
            this.LogoListProjectActive.Location = new System.Drawing.Point(22, 9);
            this.LogoListProjectActive.Name = "LogoListProjectActive";
            this.LogoListProjectActive.Size = new System.Drawing.Size(44, 60);
            this.LogoListProjectActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoListProjectActive.TabIndex = 29;
            this.LogoListProjectActive.TabStop = false;
            // 
            // LogoListProjectDed
            // 
            this.LogoListProjectDed.Image = global::TelyuProject.Properties.Resources.listDed;
            this.LogoListProjectDed.Location = new System.Drawing.Point(22, 9);
            this.LogoListProjectDed.Name = "LogoListProjectDed";
            this.LogoListProjectDed.Size = new System.Drawing.Size(44, 60);
            this.LogoListProjectDed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoListProjectDed.TabIndex = 28;
            this.LogoListProjectDed.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelyuProject.Properties.Resources.userDed;
            this.pictureBox1.Location = new System.Drawing.Point(156, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MahasiswaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelKiri);
            this.Controls.Add(this.panelMain);
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
            this.panelListProject.ResumeLayout(false);
            this.panelListProject.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMyProjectActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMyProjectDed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoListProjectDed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Panel panelListProject;
        private System.Windows.Forms.PictureBox LogoListProjectDed;
        private System.Windows.Forms.Label labelListProject;
        private System.Windows.Forms.Panel panelMyProject;
        private System.Windows.Forms.PictureBox logoMyProjectDed;
        private System.Windows.Forms.Label labelMyProject;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox LogoMyProjectActive;
        private System.Windows.Forms.PictureBox LogoListProjectActive;
        private System.Windows.Forms.Button button1;
    }
}