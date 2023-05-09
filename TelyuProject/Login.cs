﻿using System;
using System.Windows.Forms;

namespace TelyuProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            DosenMenu dosen = new DosenMenu(username);

            MessageBox.Show("Login berhasil!");
            dosen.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://igracias.telkomuniversity.ac.id/activation/forgotsso.php");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 30; // Besar radius yang diinginkan

            // Menentukan sudut-sudut yang akan diberikan radius
            path.AddArc(button.ClientRectangle.Width - radius, 0, radius, radius, 240, 90); // sudut atas kanan
            path.AddArc(button.ClientRectangle.Width - radius, button.ClientRectangle.Height - radius, radius, radius, 0, 90); // sudut bawah kanan
            path.AddArc(0, button.ClientRectangle.Height - radius, radius, radius, 90, 90); // sudut bawah kiri
            path.AddArc(0, 0, radius, radius, 180, 90); // sudut atas kiri
            path.CloseFigure();

            button.Region = new System.Drawing.Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
