using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TelyuProject.Model;

namespace TelyuProject
{
    public partial class CreateProjectForm : Form
    {

        List<String> prodi;

        public CreateProjectForm()
        {
            InitializeComponent();
            prodi = new List<String>();
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

        }

        public CreateProjectForm(string[] prodi)
        {
            InitializeComponent();
        }

        private void KontrakProyek_Click(object sender, EventArgs e)
        {

        }

        private void Skill_Click(object sender, EventArgs e)
        {

        }

        private void ProgramStudi_Click(object sender, EventArgs e)
        {

        }

        private void Deskripsi_Click(object sender, EventArgs e)
        {

        }

        private void Nama_Click(object sender, EventArgs e)
        {

        }

        private void BerlakuHingga_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 30; // Besar radius yang diinginkan

            // Menentukan sudut-sudut yang akan diberikan radius
            path.AddArc(button.ClientRectangle.Width - radius, 0, radius, radius, 270, 90); // sudut atas kanan
            path.AddArc(button.ClientRectangle.Width - radius, button.ClientRectangle.Height - radius, radius, radius, 0, 90); // sudut bawah kanan
            path.AddArc(0, button.ClientRectangle.Height - radius, radius, radius, 90, 90); // sudut bawah kiri
            path.AddArc(0, 0, radius, radius, 180, 90); // sudut atas kiri
            path.CloseFigure();

            button.Region = new System.Drawing.Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            label4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11. Visible = false;

            if (textBox1.Text.Length == 0)
            {
                label4.Visible = true;
                label4.Text = "Title tidak boleh kosong";
                valid = false;
            } else if (textBox1.Text.Length < 8)
            {
                label4.Visible = true;
                label4.Text = "Title harus lebih dari 8 huruf";
                valid = false;
            }

            if (textBox2.Text.Length == 0)
            {
                label7.Visible = true;
                label7.Text = "Deskripsi tidak boleh kosong";
                valid = false;
            } else if (textBox2.Text.Length < 10)
            {
                label7.Visible = true;
                label7.Text = "Deskripsi harus lebih dari 10 huruf";
                valid = false;
            }


            if (textBox4.Text.Length == 0)
            {
                label8.Visible = true;
                label8.Text = "Major harus dipilih dahulu";
                valid = false;
            }

            if (label3.Text.Length == 0)
            {
                label9.Visible = true;
                label9.Text = "Contract harus ditentukan";
                valid = false;
            }

            if (textBox5.Text.Length == 0)
            {
                label10.Visible = true;
                label10.Text = "Link group tidak boleh kosong";
                valid = false;
            }

            if (numericUpDown1.Value == 0)
            {
                label11.Visible = true;
                valid = false;
            }

            if (valid)
            {
                Project project = new Project
                {
                    Title = textBox1.Text,
                    Lecturer = UserSession<Dosen>.currentUser.first_name,
                    LecturerNip = UserSession<Dosen>.currentUser.NIP,
                    Description = textBox2.Text,
                    Prodi = prodi,
                    StartDate = dateTimePicker2.Value.Date,
                    EndDate = dateTimePicker1.Value.Date,
                    linkGroup = textBox5.Text,
                    quota = Convert.ToInt32(numericUpDown1.Value),
                    IsDone = false,
                    IsOpen = true
                };

                if (Data.projectList == null)
                {
                    Data.projectList = new List<Project>();
                }
                Data.projectList.Add(project);

                string json_project = JsonConvert.SerializeObject(Data.projectList, Formatting.Indented);
                File.WriteAllText("Project.json", json_project);

                this.Close();
                DosenMenu dosenm = new DosenMenu();
                dosenm.Show();
            }

           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DosenMenu dosenMenu = new DosenMenu();
            this.Close();
            dosenMenu.Show();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ControlText;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateProjectForm_StyleChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListProdi listProdi = new ListProdi();
            
            if (listProdi.ShowDialog() == DialogResult.OK)
            {
                foreach (String d in listProdi.SelectedItems)
                {
                    if (textBox4.Text == "")
                    {
                        textBox4.Text = d;
                    } else if (textBox4.Text != "" && !textBox4.Text.Contains(d))
                    {
                        textBox4.Text += ", " + d;
                    } 
                }
            }

            prodi = textBox4.Text.Split(new string[] { ", " }, StringSplitOptions.None).ToList();


        }

        public void updateData(List<String> data)
        {
            foreach (String d in data)
            {
                label3.Text =  d + " ";
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        

        private void label3_Click_2(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker2.Text + " - " + dateTimePicker1.Text;
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker2.Text + " - " + dateTimePicker1.Text;
        }

        private void TitleForm_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
