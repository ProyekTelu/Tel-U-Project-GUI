namespace TelyuProject
{
    partial class DosenMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DRequested = new System.Windows.Forms.Label();
            this.DAccepted = new System.Windows.Forms.Label();
            this.DListProject = new System.Windows.Forms.Label();
            this.CreateProject = new System.Windows.Forms.Button();
            this.Project1 = new System.Windows.Forms.Label();
            this.Project2 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel-U Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DRequested
            // 
            this.DRequested.AutoSize = true;
            this.DRequested.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRequested.Location = new System.Drawing.Point(878, 155);
            this.DRequested.Name = "DRequested";
            this.DRequested.Size = new System.Drawing.Size(138, 36);
            this.DRequested.TabIndex = 7;
            this.DRequested.Text = "Requested";
            this.DRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DRequested.Click += new System.EventHandler(this.Requested_Click);
            // 
            // DAccepted
            // 
            this.DAccepted.AutoSize = true;
            this.DAccepted.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAccepted.Location = new System.Drawing.Point(1202, 155);
            this.DAccepted.Name = "DAccepted";
            this.DAccepted.Size = new System.Drawing.Size(143, 36);
            this.DAccepted.TabIndex = 8;
            this.DAccepted.Text = "My Project";
            this.DAccepted.Click += new System.EventHandler(this.Accepted_Click);
            // 
            // DListProject
            // 
            this.DListProject.AutoSize = true;
            this.DListProject.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DListProject.Location = new System.Drawing.Point(572, 155);
            this.DListProject.Name = "DListProject";
            this.DListProject.Size = new System.Drawing.Size(145, 36);
            this.DListProject.TabIndex = 9;
            this.DListProject.Text = "List Project";
            this.DListProject.Click += new System.EventHandler(this.ListProject_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateProject.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateProject.Location = new System.Drawing.Point(1604, 894);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(194, 63);
            this.CreateProject.TabIndex = 10;
            this.CreateProject.Text = "Create Project";
            this.CreateProject.UseVisualStyleBackColor = false;
            this.CreateProject.Visible = false;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            this.CreateProject.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateProject_Paint);
            // 
            // Project1
            // 
            this.Project1.AutoSize = true;
            this.Project1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project1.Location = new System.Drawing.Point(1598, 460);
            this.Project1.Name = "Project1";
            this.Project1.Size = new System.Drawing.Size(167, 36);
            this.Project1.TabIndex = 11;
            this.Project1.Text = "Project YOLO";
            this.Project1.Click += new System.EventHandler(this.Project1_Click);
            // 
            // Project2
            // 
            this.Project2.AutoSize = true;
            this.Project2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project2.Location = new System.Drawing.Point(102, 626);
            this.Project2.Name = "Project2";
            this.Project2.Size = new System.Drawing.Size(171, 36);
            this.Project2.TabIndex = 12;
            this.Project2.Text = "Project TPLM";
            this.Project2.Click += new System.EventHandler(this.Project2_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(368, 283);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 628);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelyuProject.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(56, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1695, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DosenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Project2);
            this.Controls.Add(this.Project1);
            this.Controls.Add(this.DListProject);
            this.Controls.Add(this.DAccepted);
            this.Controls.Add(this.DRequested);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateProject);
            this.Name = "DosenMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DosenMenu";
            this.Load += new System.EventHandler(this.DosenMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DRequested;
        private System.Windows.Forms.Label DAccepted;
        private System.Windows.Forms.Label DListProject;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.Label Project1;
        private System.Windows.Forms.Label Project2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}