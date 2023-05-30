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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Explore = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(552, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel-U Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(66, 611);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Muhammad Zaky Faturahim";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DRequested
            // 
            this.DRequested.AutoSize = true;
            this.DRequested.BackColor = System.Drawing.Color.Transparent;
            this.DRequested.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRequested.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DRequested.Location = new System.Drawing.Point(2, 54);
            this.DRequested.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.DRequested.Name = "DRequested";
            this.DRequested.Size = new System.Drawing.Size(118, 34);
            this.DRequested.TabIndex = 7;
            this.DRequested.Text = "Requested";
            this.DRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DRequested.Click += new System.EventHandler(this.Requested_Click);
            // 
            // DAccepted
            // 
            this.DAccepted.AutoSize = true;
            this.DAccepted.BackColor = System.Drawing.Color.Transparent;
            this.DAccepted.CausesValidation = false;
            this.DAccepted.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAccepted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DAccepted.Location = new System.Drawing.Point(2, 98);
            this.DAccepted.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.DAccepted.Name = "DAccepted";
            this.DAccepted.Size = new System.Drawing.Size(113, 34);
            this.DAccepted.TabIndex = 8;
            this.DAccepted.Text = "My Project";
            this.DAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DAccepted.Click += new System.EventHandler(this.Accepted_Click);
            // 
            // DListProject
            // 
            this.DListProject.AutoSize = true;
            this.DListProject.BackColor = System.Drawing.Color.Transparent;
            this.DListProject.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DListProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DListProject.Location = new System.Drawing.Point(2, 10);
            this.DListProject.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.DListProject.Name = "DListProject";
            this.DListProject.Size = new System.Drawing.Size(116, 34);
            this.DListProject.TabIndex = 9;
            this.DListProject.Text = "List Project";
            this.DListProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DListProject.Click += new System.EventHandler(this.ListProject_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateProject.BackColor = System.Drawing.Color.AliceBlue;
            this.CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProject.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateProject.Location = new System.Drawing.Point(683, 92);
            this.CreateProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(161, 57);
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
            this.Project1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Project1.Location = new System.Drawing.Point(452, 335);
            this.Project1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Project1.Name = "Project1";
            this.Project1.Size = new System.Drawing.Size(135, 34);
            this.Project1.TabIndex = 11;
            this.Project1.Text = "Project YOLO";
            this.Project1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project1.Click += new System.EventHandler(this.Project1_Click);
            // 
            // Project2
            // 
            this.Project2.AutoSize = true;
            this.Project2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Project2.Location = new System.Drawing.Point(356, 289);
            this.Project2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Project2.Name = "Project2";
            this.Project2.Size = new System.Drawing.Size(131, 34);
            this.Project2.TabIndex = 12;
            this.Project2.Text = "Project TPLM";
            this.Project2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Project2.Click += new System.EventHandler(this.Project2_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Project2);
            this.panel1.Controls.Add(this.Project1);
            this.panel1.Location = new System.Drawing.Point(374, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 408);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelyuProject.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(17, 603);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1130, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.Explore);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 682);
            this.panel2.TabIndex = 16;
            // 
            // Explore
            // 
            this.Explore.AutoSize = true;
            this.Explore.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Explore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Explore.Location = new System.Drawing.Point(38, 29);
            this.Explore.Name = "Explore";
            this.Explore.Size = new System.Drawing.Size(93, 37);
            this.Explore.TabIndex = 18;
            this.Explore.Text = "Explore";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DListProject);
            this.flowLayoutPanel1.Controls.Add(this.DRequested);
            this.flowLayoutPanel1.Controls.Add(this.DAccepted);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 194);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(357, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 18;
            // 
            // DosenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateProject);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DosenMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DosenMenu";
            this.Load += new System.EventHandler(this.DosenMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Explore;
        private System.Windows.Forms.Panel panel4;
    }
}