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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel-U Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DRequested
            // 
            this.DRequested.AutoSize = true;
            this.DRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRequested.Location = new System.Drawing.Point(591, 101);
            this.DRequested.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DRequested.Name = "DRequested";
            this.DRequested.Size = new System.Drawing.Size(88, 20);
            this.DRequested.TabIndex = 7;
            this.DRequested.Text = "Requested";
            this.DRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DRequested.Click += new System.EventHandler(this.Requested_Click);
            // 
            // DAccepted
            // 
            this.DAccepted.AutoSize = true;
            this.DAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAccepted.Location = new System.Drawing.Point(801, 101);
            this.DAccepted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DAccepted.Name = "DAccepted";
            this.DAccepted.Size = new System.Drawing.Size(82, 20);
            this.DAccepted.TabIndex = 8;
            this.DAccepted.Text = "My Project";
            this.DAccepted.Click += new System.EventHandler(this.Accepted_Click);
            // 
            // DListProject
            // 
            this.DListProject.AutoSize = true;
            this.DListProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DListProject.Location = new System.Drawing.Point(382, 101);
            this.DListProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DListProject.Name = "DListProject";
            this.DListProject.Size = new System.Drawing.Size(87, 20);
            this.DListProject.TabIndex = 9;
            this.DListProject.Text = "List Project";
            this.DListProject.Click += new System.EventHandler(this.ListProject_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateProject.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProject.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateProject.Location = new System.Drawing.Point(1020, 526);
            this.CreateProject.Margin = new System.Windows.Forms.Padding(2);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(129, 41);
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
            this.Project1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project1.Location = new System.Drawing.Point(1083, 163);
            this.Project1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Project1.Name = "Project1";
            this.Project1.Size = new System.Drawing.Size(106, 20);
            this.Project1.TabIndex = 11;
            this.Project1.Text = "Project YOLO";
            this.Project1.Click += new System.EventHandler(this.Project1_Click);
            // 
            // Project2
            // 
            this.Project2.AutoSize = true;
            this.Project2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project2.Location = new System.Drawing.Point(1127, 243);
            this.Project2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Project2.Name = "Project2";
            this.Project2.Size = new System.Drawing.Size(103, 20);
            this.Project2.TabIndex = 12;
            this.Project2.Text = "Project TPLM";
            this.Project2.Click += new System.EventHandler(this.Project2_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(350, 173);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 385);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // DosenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Project2);
            this.Controls.Add(this.Project1);
            this.Controls.Add(this.DListProject);
            this.Controls.Add(this.DAccepted);
            this.Controls.Add(this.DRequested);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateProject);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DosenMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DosenMenu";
            this.Load += new System.EventHandler(this.DosenMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}