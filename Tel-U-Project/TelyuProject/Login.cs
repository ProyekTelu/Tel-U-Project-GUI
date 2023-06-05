using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using TelyuProject.Model;

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
            string dataMahasiswaString = File.ReadAllText("DataMahasiswa.json");
            Data.mahasiswaList.data = JsonConvert.DeserializeObject<List<Mahasiswa>>(dataMahasiswaString);

            string passwordMahasiswaString = File.ReadAllText("PasswordMahasiswa.json");
            Data.mahasiswaList.password = JsonConvert.DeserializeObject<List<String>>(passwordMahasiswaString);

            string dataDosenString = File.ReadAllText("DataDosen.json");
            Data.dosenList.data = JsonConvert.DeserializeObject<List<Dosen>>(dataDosenString);

            string passwordDosenString = File.ReadAllText("PasswordDosen.json");
            Data.dosenList.password = JsonConvert.DeserializeObject<List<String>>(passwordDosenString);

            string projectString = File.ReadAllText("Project.json");
            Data.projectList = JsonConvert.DeserializeObject<List<Project>>(projectString);

            string dataRequestString = File.ReadAllText("DataRequested.json");
            Data.requestList = JsonConvert.DeserializeObject<List<Requested>>(dataRequestString);
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
            if (EmailTextBox.Text.Contains("student"))
            {
                for (int i = 0; i < Data.mahasiswaList.data.Count; i++)
                {
                    if (EmailTextBox.Text.Equals(Data.mahasiswaList.data[i].email))
                    {
                        if (PasswordTextBox.Text.Equals(Data.mahasiswaList.password[i]))
                        {
                            UserSession<Mahasiswa>.currentUser = Data.mahasiswaList.data[i];
                            MessageBox.Show("Login Berhasil");
                            MahasiswaMenu mahasiswamenu = new MahasiswaMenu();
                            mahasiswamenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password anda salah");
                            PasswordTextBox.Clear();
                            PasswordTextBox.Focus();
                        }
                        return;
                    }
                }
            } else if (!EmailTextBox.Text.Equals(""))
            {
                for (int i = 0; i < Data.dosenList.data.Count; i++)
                {
                    if (EmailTextBox.Text.Equals(Data.dosenList.data[i].email))
                    {
                       
                        if (PasswordTextBox.Text.Equals(Data.dosenList.password[i]))
                        {
                            UserSession<Dosen>.currentUser = Data.dosenList.data[i];
                            DosenMenu dosen_menu = new DosenMenu();
                            MessageBox.Show("Login Berhasil");
                            dosen_menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password anda salah");
                            PasswordTextBox.Clear();
                            PasswordTextBox.Focus();
                        }
                        return;
                    }
                }
            } else
            {
                MessageBox.Show("Mohon Isi Email Anda");
                return;
            }
            

            
            MessageBox.Show("Email tidak ditemukan, jika anda belum pernah mendaftar pada aplikasi kami tekan sign up");
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
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
            this.Hide();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
