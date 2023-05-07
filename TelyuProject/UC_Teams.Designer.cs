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
            this.tableTeam2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTeam2)).BeginInit();
            this.SuspendLayout();
            // 
            // team1
            // 
            this.team1.AutoSize = true;
            this.team1.BackColor = System.Drawing.Color.Red;
            this.team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.team1.Location = new System.Drawing.Point(74, 0);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(71, 22);
            this.team1.TabIndex = 17;
            this.team1.Text = "Team 1";
            this.team1.Click += new System.EventHandler(this.team1_Click);
            // 
            // tableTeam
            // 
            this.tableTeam.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.NIM,
            this.Fakultas});
            this.tableTeam.Location = new System.Drawing.Point(78, 38);
            this.tableTeam.Name = "tableTeam";
            this.tableTeam.RowHeadersWidth = 51;
            this.tableTeam.RowTemplate.Height = 24;
            this.tableTeam.Size = new System.Drawing.Size(753, 157);
            this.tableTeam.TabIndex = 16;
            this.tableTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableTeam_CellContentClick);
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 200;
            // 
            // NIM
            // 
            this.NIM.HeaderText = "NIM";
            this.NIM.MinimumWidth = 6;
            this.NIM.Name = "NIM";
            this.NIM.Width = 125;
            // 
            // Fakultas
            // 
            this.Fakultas.HeaderText = "Fakultas";
            this.Fakultas.MinimumWidth = 6;
            this.Fakultas.Name = "Fakultas";
            this.Fakultas.Width = 200;
            // 
            // tableTeam2
            // 
            this.tableTeam2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableTeam2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTeam2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableTeam2.Location = new System.Drawing.Point(78, 283);
            this.tableTeam2.Name = "tableTeam2";
            this.tableTeam2.RowHeadersWidth = 51;
            this.tableTeam2.RowTemplate.Height = 24;
            this.tableTeam2.Size = new System.Drawing.Size(753, 142);
            this.tableTeam2.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NIM";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fakultas";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // team2
            // 
            this.team2.AutoSize = true;
            this.team2.BackColor = System.Drawing.Color.Red;
            this.team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.team2.Location = new System.Drawing.Point(74, 248);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(71, 22);
            this.team2.TabIndex = 19;
            this.team2.Text = "Team 2";
            // 
            // UC_Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.team2);
            this.Controls.Add(this.tableTeam2);
            this.Controls.Add(this.team1);
            this.Controls.Add(this.tableTeam);
            this.Name = "UC_Teams";
            this.Size = new System.Drawing.Size(912, 458);
            ((System.ComponentModel.ISupportInitialize)(this.tableTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTeam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label team1;
        private System.Windows.Forms.DataGridView tableTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fakultas;
        private System.Windows.Forms.DataGridView tableTeam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label team2;
    }
}
