namespace TelyuProject
{
    partial class UC_Teams
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
            this.team1 = new System.Windows.Forms.Label();
            this.tableTeam = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fakultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // team1
            // 
            this.team1.AutoSize = true;
            this.team1.BackColor = System.Drawing.Color.Red;
            this.team1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.team1.Location = new System.Drawing.Point(2, 9);
            this.team1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(107, 19);
            this.team1.TabIndex = 17;
            this.team1.Text = "Team Member";
            this.team1.Click += new System.EventHandler(this.team1_Click);
            // 
            // tableTeam
            // 
            this.tableTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(62)))));
            this.tableTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.NIM,
            this.Fakultas});
            this.tableTeam.Location = new System.Drawing.Point(2, 32);
            this.tableTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableTeam.Name = "tableTeam";
            this.tableTeam.RowHeadersWidth = 51;
            this.tableTeam.RowTemplate.Height = 24;
            this.tableTeam.Size = new System.Drawing.Size(749, 372);
            this.tableTeam.TabIndex = 16;
            this.tableTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableTeam_CellContentClick);
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 300;
            // 
            // NIM
            // 
            this.NIM.HeaderText = "NIM";
            this.NIM.MinimumWidth = 6;
            this.NIM.Name = "NIM";
            this.NIM.Width = 200;
            // 
            // Fakultas
            // 
            this.Fakultas.HeaderText = "Fakultas";
            this.Fakultas.MinimumWidth = 6;
            this.Fakultas.Name = "Fakultas";
            this.Fakultas.Width = 200;
            // 
            // UC_Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.team1);
            this.Controls.Add(this.tableTeam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Teams";
            this.Size = new System.Drawing.Size(749, 372);
            ((System.ComponentModel.ISupportInitialize)(this.tableTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label team1;
        private System.Windows.Forms.DataGridView tableTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fakultas;
    }
}
