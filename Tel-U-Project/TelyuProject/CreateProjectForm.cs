﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace TelyuProject
{
    public partial class CreateProjectForm : Form
    {

        List<String> prodi;
        private string username;

        public CreateProjectForm(String username)
        {
            InitializeComponent();
            this.username = username;
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
            Project project = new Project
            {
                Title = textBox1.Text,
                Lecturer = username,
                Description = textBox2.Text,
                Prodi = prodi,
                StartDate = new DateTime(2022, 3, 1),
                EndDate = new DateTime(2022, 8, 31),
                linkGroup = textBox5.Text,
                quota = Convert.ToInt32(numericUpDown1.Value),
                IsDone = false,
                IsOpen = true
            };

            Data.projectList.Add(project);

            string json_project = JsonConvert.SerializeObject(Data.projectList, Formatting.Indented);
            File.WriteAllText("Project.json", json_project);

            this.Close();
            DosenMenu dosenm = new DosenMenu(username);
            dosenm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DosenMenu dosenMenu = new DosenMenu(username);
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
            label3.Text = dateTimePicker1.Text + " - " + dateTimePicker2.Text;
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Text + " - " + dateTimePicker2.Text;
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
    }
}