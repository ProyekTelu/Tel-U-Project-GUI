namespace TelyuProject
{
    partial class UC_ListProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emptyAnnounceProject = new System.Windows.Forms.Label();
            this.existProjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(849, 412);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lecture";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lecture NIP";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Major";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contract";
            this.columnHeader6.Width = 133;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quota";
            this.columnHeader7.Width = 85;
            // 
            // emptyAnnounceProject
            // 
            this.emptyAnnounceProject.AutoSize = true;
            this.emptyAnnounceProject.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyAnnounceProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emptyAnnounceProject.Location = new System.Drawing.Point(187, 207);
            this.emptyAnnounceProject.Name = "emptyAnnounceProject";
            this.emptyAnnounceProject.Size = new System.Drawing.Size(479, 28);
            this.emptyAnnounceProject.TabIndex = 1;
            this.emptyAnnounceProject.Text = "Sorry currently there is no open recruitment for any project.";
            this.emptyAnnounceProject.Visible = false;
            this.emptyAnnounceProject.Click += new System.EventHandler(this.emptyAnnounceProject_Click);
            // 
            // existProjectLabel
            // 
            this.existProjectLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existProjectLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.existProjectLabel.Location = new System.Drawing.Point(239, 4);
            this.existProjectLabel.Name = "existProjectLabel";
            this.existProjectLabel.Size = new System.Drawing.Size(374, 23);
            this.existProjectLabel.TabIndex = 0;
            this.existProjectLabel.Text = "*Double Click Project Title to Join Project";
            this.existProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.existProjectLabel.Visible = false;
            this.existProjectLabel.Click += new System.EventHandler(this.existProjectLabel_Click);
            // 
            // UC_ListProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.existProjectLabel);
            this.Controls.Add(this.emptyAnnounceProject);
            this.Controls.Add(this.listView1);
            this.Name = "UC_ListProject";
            this.Size = new System.Drawing.Size(852, 442);
            this.Load += new System.EventHandler(this.UC_ListProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label emptyAnnounceProject;
        private System.Windows.Forms.Label existProjectLabel;
    }
}
