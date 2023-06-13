namespace TelyuProject
{
    partial class ProjectDetails
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
            this.LTeams = new System.Windows.Forms.Label();
            this.LInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.JoinProject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1124, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project YOLO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LTeams
            // 
            this.LTeams.AutoSize = true;
            this.LTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTeams.Location = new System.Drawing.Point(99, 495);
            this.LTeams.Name = "LTeams";
            this.LTeams.Size = new System.Drawing.Size(68, 24);
            this.LTeams.TabIndex = 1;
            this.LTeams.Text = "Teams";
            this.LTeams.Click += new System.EventHandler(this.LTeams_Click);
            // 
            // LInfo
            // 
            this.LInfo.AutoSize = true;
            this.LInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfo.Location = new System.Drawing.Point(99, 422);
            this.LInfo.Name = "LInfo";
            this.LInfo.Size = new System.Drawing.Size(40, 24);
            this.LInfo.TabIndex = 2;
            this.LInfo.Text = "Info";
            this.LInfo.Click += new System.EventHandler(this.LInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "<-- Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(210, 263);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1124, 572);
            this.panelContainer.TabIndex = 16;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(88)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LTeams);
            this.panel1.Controls.Add(this.LInfo);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 1058);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.JoinProject);
            this.panel2.Controls.Add(this.panelContainer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(375, -3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1524, 1058);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // JoinProject
            // 
            this.JoinProject.BackColor = System.Drawing.Color.AliceBlue;
            this.JoinProject.Font = new System.Drawing.Font("Poppins", 12F);
            this.JoinProject.Location = new System.Drawing.Point(515, 894);
            this.JoinProject.Name = "JoinProject";
            this.JoinProject.Size = new System.Drawing.Size(473, 85);
            this.JoinProject.TabIndex = 19;
            this.JoinProject.Text = "Join Project";
            this.JoinProject.UseVisualStyleBackColor = false;
            this.JoinProject.Click += new System.EventHandler(this.JoinProject_Click);
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1900, 1052);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ProjectDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDetails";
            this.Load += new System.EventHandler(this.ProjectDetails_Load);
            this.Shown += new System.EventHandler(this.ProjectDetails_Shown);
            this.StyleChanged += new System.EventHandler(this.ProjectDetails_StyleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LTeams;
        private System.Windows.Forms.Label LInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button JoinProject;
    }
}