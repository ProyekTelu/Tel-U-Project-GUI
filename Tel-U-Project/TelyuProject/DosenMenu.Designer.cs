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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelKiri = new System.Windows.Forms.Panel();
            this.Explore = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panelKiri.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(421, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel-U Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(2, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zaky";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DRequested
            // 
            this.DRequested.AutoSize = true;
            this.DRequested.BackColor = System.Drawing.Color.Transparent;
            this.DRequested.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRequested.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DRequested.Location = new System.Drawing.Point(2, 108);
            this.DRequested.Margin = new System.Windows.Forms.Padding(2, 0, 2, 20);
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
            this.DAccepted.Location = new System.Drawing.Point(2, 54);
            this.DAccepted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 20);
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
            this.DListProject.Location = new System.Drawing.Point(2, 0);
            this.DListProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 20);
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
            this.CreateProject.Location = new System.Drawing.Point(665, 591);
            this.CreateProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(224, 54);
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
            this.Project1.Location = new System.Drawing.Point(421, 601);
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
            this.Project2.Location = new System.Drawing.Point(998, 603);
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
            this.panel1.Location = new System.Drawing.Point(326, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 442);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 591);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelKiri
            // 
            this.panelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.panelKiri.Controls.Add(this.button1);
            this.panelKiri.Controls.Add(this.Explore);
            this.panelKiri.Controls.Add(this.flowLayoutPanel1);
            this.panelKiri.Controls.Add(this.panel2);
            this.panelKiri.Location = new System.Drawing.Point(-1, 0);
            this.panelKiri.Name = "panelKiri";
            this.panelKiri.Size = new System.Drawing.Size(266, 682);
            this.panelKiri.TabIndex = 16;
            // 
            // Explore
            // 
            this.Explore.AutoSize = true;
            this.Explore.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Explore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Explore.Location = new System.Drawing.Point(36, 193);
            this.Explore.Name = "Explore";
            this.Explore.Size = new System.Drawing.Size(93, 37);
            this.Explore.TabIndex = 18;
            this.Explore.Text = "Explore";
            this.Explore.Click += new System.EventHandler(this.Explore_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DListProject);
            this.flowLayoutPanel1.Controls.Add(this.DAccepted);
            this.flowLayoutPanel1.Controls.Add(this.DRequested);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 254);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 161);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.panelAtas.Controls.Add(this.label1);
            this.panelAtas.Location = new System.Drawing.Point(265, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1002, 68);
            this.panelAtas.TabIndex = 17;
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // DosenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Project2);
            this.Controls.Add(this.panelKiri);
            this.Controls.Add(this.Project1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateProject);
            this.Controls.Add(this.panelAtas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DosenMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DosenMenu";
            this.Load += new System.EventHandler(this.DosenMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panelKiri.ResumeLayout(false);
            this.panelKiri.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelKiri;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Explore;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}