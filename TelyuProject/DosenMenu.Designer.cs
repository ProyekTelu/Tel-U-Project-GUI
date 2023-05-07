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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CreateProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tel-U Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DRequested
            // 
            this.DRequested.AutoSize = true;
            this.DRequested.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRequested.Location = new System.Drawing.Point(626, 152);
            this.DRequested.Name = "DRequested";
            this.DRequested.Size = new System.Drawing.Size(144, 33);
            this.DRequested.TabIndex = 7;
            this.DRequested.Text = "Requested";
            this.DRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DRequested.Click += new System.EventHandler(this.Requested_Click);
            // 
            // DAccepted
            // 
            this.DAccepted.AutoSize = true;
            this.DAccepted.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAccepted.Location = new System.Drawing.Point(949, 152);
            this.DAccepted.Name = "DAccepted";
            this.DAccepted.Size = new System.Drawing.Size(143, 33);
            this.DAccepted.TabIndex = 8;
            this.DAccepted.Text = "My Project";
            this.DAccepted.Click += new System.EventHandler(this.Accepted_Click);
            // 
            // DListProject
            // 
            this.DListProject.AutoSize = true;
            this.DListProject.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DListProject.Location = new System.Drawing.Point(320, 152);
            this.DListProject.Name = "DListProject";
            this.DListProject.Size = new System.Drawing.Size(149, 33);
            this.DListProject.TabIndex = 9;
            this.DListProject.Text = "List Project";
            this.DListProject.Click += new System.EventHandler(this.ListProject_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateProject.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProject.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateProject.Location = new System.Drawing.Point(1169, 693);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(194, 62);
            this.CreateProject.TabIndex = 10;
            this.CreateProject.Text = "Create Project";
            this.CreateProject.UseVisualStyleBackColor = false;
            this.CreateProject.Visible = false;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            this.CreateProject.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateProject_Paint);
            // 
            // DosenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1425, 815);
            this.Controls.Add(this.DListProject);
            this.Controls.Add(this.DAccepted);
            this.Controls.Add(this.DRequested);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateProject);
            this.Name = "DosenMenu";
            this.Text = "DosenMenu";
            this.Load += new System.EventHandler(this.DosenMenu_Load);
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
    }
}