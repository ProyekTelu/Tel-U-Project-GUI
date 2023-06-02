namespace TelyuProject
{
    partial class UC_MyProject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureNipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.LectureColumn,
            this.LectureNipColumn,
            this.DescriptionColumn,
            this.MajorColumn,
            this.ContractColumn,
            this.QuotaColumn,
            this.StatusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.Width = 120;
            // 
            // LectureColumn
            // 
            this.LectureColumn.HeaderText = "Lecture";
            this.LectureColumn.Name = "LectureColumn";
            // 
            // LectureNipColumn
            // 
            this.LectureNipColumn.HeaderText = "Lecture NIP";
            this.LectureNipColumn.Name = "LectureNipColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // MajorColumn
            // 
            this.MajorColumn.HeaderText = "Major";
            this.MajorColumn.Name = "MajorColumn";
            // 
            // ContractColumn
            // 
            this.ContractColumn.HeaderText = "Contract";
            this.ContractColumn.Name = "ContractColumn";
            // 
            // QuotaColumn
            // 
            this.QuotaColumn.HeaderText = "Quota";
            this.QuotaColumn.Name = "QuotaColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // UC_MyProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UC_MyProject";
            this.Size = new System.Drawing.Size(869, 447);
            this.Load += new System.EventHandler(this.UC_MyProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureNipColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}
