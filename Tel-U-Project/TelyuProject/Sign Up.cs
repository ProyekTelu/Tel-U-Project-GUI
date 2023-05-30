using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelyuProject
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        public Sign_Up(String first_name, String last_name, String email)
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!TEmail.Text.Contains("@student.telkomuniversity.ac.id") && !TEmail.Text.Contains("@telkomuniversity.ac.id"))
            {
                MessageBox.Show("Mohon masukan email sesuai dengan format");
                TEmail.Focus();
            } else if (TFirstName.Text.Equals("") || TLastName.Text.Equals("") || TPassword.Text.Equals(""))
            {
                MessageBox.Show("Mohon masukan data yang kosong");
            } else if (TEmail.Text.Contains("@student.telkomuniversity.ac.id"))
            {
                Mahasiswa mahasiswa = new Mahasiswa();
                mahasiswa.first_name = TFirstName.Text;
                mahasiswa.last_name = TLastName.Text;
                mahasiswa.email = TEmail.Text;

                
                SignUpMahasiswa sign_up_mahasiswa = new SignUpMahasiswa(TPassword.Text, mahasiswa);
                sign_up_mahasiswa.Show();
                this.Hide();
            } else
            {
                Dosen dosen = new Dosen();
                dosen.first_name = TFirstName.Text;
                dosen.last_name = TLastName.Text;
                dosen.email = TEmail.Text;

                SignUpDosen sign_up_dosen = new SignUpDosen(TPassword.Text, dosen);
                sign_up_dosen.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Email

        }

        private void TFirstName_TextChanged(object sender, EventArgs e)
        {
            //First Name
        }

        private void TLastName_TextChanged(object sender, EventArgs e)
        {
            //Last Name
        }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            //Password
        }
    }
}
