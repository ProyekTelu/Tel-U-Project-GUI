﻿namespace TelyuProject
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project YOLO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LTeams
            // 
            this.LTeams.AutoSize = true;
            this.LTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTeams.Location = new System.Drawing.Point(643, 128);
            this.LTeams.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTeams.Name = "LTeams";
            this.LTeams.Size = new System.Drawing.Size(68, 24);
            this.LTeams.TabIndex = 1;
            this.LTeams.Text = "Teams";
            this.LTeams.Click += new System.EventHandler(this.LTeams_Click);
            // 
            // LInfo
            // 
            this.LInfo.AutoSize = true;
            this.LInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfo.Location = new System.Drawing.Point(521, 128);
            this.LInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LInfo.Name = "LInfo";
            this.LInfo.Size = new System.Drawing.Size(40, 24);
            this.LInfo.TabIndex = 2;
            this.LInfo.Text = "Info";
            this.LInfo.Click += new System.EventHandler(this.LInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "<-- Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(272, 174);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(684, 372);
            this.panelContainer.TabIndex = 16;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.LTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProjectDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDetails";
            this.Load += new System.EventHandler(this.ProjectDetails_Load);
            this.Shown += new System.EventHandler(this.ProjectDetails_Shown);
            this.StyleChanged += new System.EventHandler(this.ProjectDetails_StyleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LTeams;
        private System.Windows.Forms.Label LInfo;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelContainer;
    }
}