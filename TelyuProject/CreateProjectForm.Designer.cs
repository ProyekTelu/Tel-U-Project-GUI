namespace TelyuProject
{
    partial class CreateProjectForm
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
            this.Nama = new System.Windows.Forms.Label();
            this.Deskripsi = new System.Windows.Forms.Label();
            this.ProgramStudi = new System.Windows.Forms.Label();
            this.Skill = new System.Windows.Forms.Label();
            this.KontrakProyek = new System.Windows.Forms.Label();
            this.Tim = new System.Windows.Forms.Label();
            this.BerlakuHingga = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TitleForm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.Color.DarkGray;
            this.Nama.Location = new System.Drawing.Point(273, 165);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(89, 33);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            this.Nama.Click += new System.EventHandler(this.Nama_Click);
            // 
            // Deskripsi
            // 
            this.Deskripsi.AutoSize = true;
            this.Deskripsi.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deskripsi.ForeColor = System.Drawing.Color.DarkGray;
            this.Deskripsi.Location = new System.Drawing.Point(229, 234);
            this.Deskripsi.Name = "Deskripsi";
            this.Deskripsi.Size = new System.Drawing.Size(133, 33);
            this.Deskripsi.TabIndex = 1;
            this.Deskripsi.Text = "Deskripsi";
            this.Deskripsi.Click += new System.EventHandler(this.Deskripsi_Click);
            // 
            // ProgramStudi
            // 
            this.ProgramStudi.AutoSize = true;
            this.ProgramStudi.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramStudi.ForeColor = System.Drawing.Color.DarkGray;
            this.ProgramStudi.Location = new System.Drawing.Point(165, 357);
            this.ProgramStudi.Name = "ProgramStudi";
            this.ProgramStudi.Size = new System.Drawing.Size(197, 33);
            this.ProgramStudi.TabIndex = 2;
            this.ProgramStudi.Text = "Program Studi";
            this.ProgramStudi.Click += new System.EventHandler(this.ProgramStudi_Click);
            // 
            // Skill
            // 
            this.Skill.AutoSize = true;
            this.Skill.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.Skill.ForeColor = System.Drawing.Color.DarkGray;
            this.Skill.Location = new System.Drawing.Point(295, 427);
            this.Skill.Name = "Skill";
            this.Skill.Size = new System.Drawing.Size(67, 33);
            this.Skill.TabIndex = 3;
            this.Skill.Text = "Skill";
            this.Skill.Click += new System.EventHandler(this.Skill_Click);
            // 
            // KontrakProyek
            // 
            this.KontrakProyek.AutoSize = true;
            this.KontrakProyek.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.KontrakProyek.ForeColor = System.Drawing.Color.DarkGray;
            this.KontrakProyek.Location = new System.Drawing.Point(151, 489);
            this.KontrakProyek.Name = "KontrakProyek";
            this.KontrakProyek.Size = new System.Drawing.Size(211, 33);
            this.KontrakProyek.TabIndex = 4;
            this.KontrakProyek.Text = "Kontrak Proyek";
            this.KontrakProyek.Click += new System.EventHandler(this.KontrakProyek_Click);
            // 
            // Tim
            // 
            this.Tim.AutoSize = true;
            this.Tim.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.Tim.ForeColor = System.Drawing.Color.DarkGray;
            this.Tim.Location = new System.Drawing.Point(300, 550);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(62, 33);
            this.Tim.TabIndex = 5;
            this.Tim.Text = "Tim";
            // 
            // BerlakuHingga
            // 
            this.BerlakuHingga.AutoSize = true;
            this.BerlakuHingga.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.BerlakuHingga.ForeColor = System.Drawing.Color.DarkGray;
            this.BerlakuHingga.Location = new System.Drawing.Point(151, 613);
            this.BerlakuHingga.Name = "BerlakuHingga";
            this.BerlakuHingga.Size = new System.Drawing.Size(211, 33);
            this.BerlakuHingga.TabIndex = 6;
            this.BerlakuHingga.Text = "Berlaku Hingga";
            this.BerlakuHingga.Click += new System.EventHandler(this.BerlakuHingga_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(454, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 40);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBox2.Location = new System.Drawing.Point(454, 232);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(597, 97);
            this.textBox2.TabIndex = 9;
            // 
            // TitleForm
            // 
            this.TitleForm.AutoSize = true;
            this.TitleForm.Font = new System.Drawing.Font("Montserrat SemiBold", 22F, System.Drawing.FontStyle.Bold);
            this.TitleForm.Location = new System.Drawing.Point(443, 48);
            this.TitleForm.Name = "TitleForm";
            this.TitleForm.Size = new System.Drawing.Size(349, 61);
            this.TitleForm.TabIndex = 10;
            this.TitleForm.Text = "Create Project";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(977, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 68);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "<-- Kembali";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(454, 357);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(597, 44);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TitleForm);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BerlakuHingga);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.KontrakProyek);
            this.Controls.Add(this.Skill);
            this.Controls.Add(this.ProgramStudi);
            this.Controls.Add(this.Deskripsi);
            this.Controls.Add(this.Nama);
            this.Name = "CreateProjectForm";
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.CreateProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Deskripsi;
        private System.Windows.Forms.Label ProgramStudi;
        private System.Windows.Forms.Label Skill;
        private System.Windows.Forms.Label KontrakProyek;
        private System.Windows.Forms.Label Tim;
        private System.Windows.Forms.Label BerlakuHingga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TitleForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}