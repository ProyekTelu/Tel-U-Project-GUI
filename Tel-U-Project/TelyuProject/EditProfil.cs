using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelyuProject.Model;

namespace TelyuProject
{
    public partial class EditProfil : Form
    {

        public EditProfil()
        {
            InitializeComponent();

            if(UserSession<Dosen>.currentUser != null && UserSession<Dosen>.currentUser.GetType() == typeof(Dosen))
            {
                EditFirstName.Text = UserSession<Dosen>.currentUser.first_name;
                EditLastName.Text = UserSession<Dosen>.currentUser.last_name;
                EditStudentID.Text = UserSession<Dosen>.currentUser.NIP;
                EditProfilEmail.Text = UserSession<Dosen>.currentUser.email;
                EStudentID.Text = "Lecture ID";
            }
            else
            {
                EditFirstName.Text = UserSession<Mahasiswa>.currentUser.first_name;
                EditLastName.Text = UserSession<Mahasiswa>.currentUser.last_name;
                EditStudentID.Text = UserSession<Mahasiswa>.currentUser.NIM;
                EditProfilEmail.Text = UserSession<Mahasiswa>.currentUser.email;
            }


            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

        }

        private void Nama_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string oldPassword = OldPassword.Text;
            string newPassword = NewPassword.Text;
            string confirmPassword = ConfirmPassword.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the password fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            if (UserSession<Dosen>.currentUser != null && UserSession<Dosen>.currentUser.GetType() == typeof(Dosen))
            {
                int index = Data.dosenList.data.FindIndex(d => d.email == UserSession<Dosen>.currentUser.email);
                if (index >= 0)
                {
                    if (Data.dosenList.password[index] == oldPassword)
                    {
                        Data.dosenList.password[index] = newPassword;

                        string passwordDosenString = JsonConvert.SerializeObject(Data.dosenList.password);
                        File.WriteAllText("PasswordDosen.json", passwordDosenString);

                        MessageBox.Show("Password updated successfully.");
                        Profil profil = new Profil();
                        profil.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Old password is incorrect.");
                    }
                }
            }
            else
            {
                int index = Data.mahasiswaList.data.FindIndex(m => m.email == UserSession<Mahasiswa>.currentUser.email);
                if (index >= 0)
                {
                    if (Data.mahasiswaList.password[index] == oldPassword)
                    {
                        Data.mahasiswaList.password[index] = newPassword;

                        string passwordMahasiswaString = JsonConvert.SerializeObject(Data.mahasiswaList.password);
                        File.WriteAllText("PasswordMahasiswa.json", passwordMahasiswaString);

                        MessageBox.Show("Password updated successfully.");
                        Profil profil = new Profil();
                        profil.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Old password is incorrect.");
                    }
                }
            }
        }

        private void TitleForm_Click(object sender, EventArgs e)
        {

        }

        private void EditProfil_Load(object sender, EventArgs e)
        {

        }

        private void EditProfil_StyleChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassword.Checked)
            {
                OldPassword.UseSystemPasswordChar = false;
                NewPassword.UseSystemPasswordChar = false;
                ConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                OldPassword.UseSystemPasswordChar = true;
                NewPassword.UseSystemPasswordChar = true;
                ConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
