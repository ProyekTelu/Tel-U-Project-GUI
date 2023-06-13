using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelyuProject.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TelyuProject
{
    public partial class Profil : Form
    {

        public Profil()
        {
            InitializeComponent();


            if (UserSession<Dosen>.currentUser != null && UserSession<Dosen>.currentUser.GetType() == typeof(Dosen))
            {
                labelProfilName.Text = UserSession<Dosen>.currentUser.first_name;
                labelProfilLName.Text = UserSession<Dosen>.currentUser.last_name;
                labelProfilSID.Text = UserSession<Dosen>.currentUser.NIP;
                labelProfilEmail.Text = UserSession<Dosen>.currentUser.email;
                labelProfilMajor.Text = UserSession<Dosen>.currentUser.prodi;
                labelProfilPhone.Text = UserSession<Dosen>.currentUser.phone;
                StudentID.Text = "Lecture ID";
            }
            else
            {
                labelProfilName.Text = UserSession<Mahasiswa>.currentUser.first_name;
                labelProfilLName.Text = UserSession<Mahasiswa>.currentUser.last_name;
                labelProfilSID.Text = UserSession<Mahasiswa>.currentUser.NIM;
                labelProfilEmail.Text = UserSession<Mahasiswa>.currentUser.email;
                labelProfilMajor.Text = UserSession<Mahasiswa>.currentUser.prodi;
                labelProfilPhone.Text = UserSession<Mahasiswa>.currentUser.phone;
            }

            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }

        private void Profil_StyleChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (UserSession<Dosen>.currentUser != null && UserSession<Dosen>.currentUser.GetType() == typeof(Dosen))
            {
                DosenMenu dosenMenu = new DosenMenu();
                dosenMenu.Show();
                this.Hide();
            }
            else
            {
                MahasiswaMenu mahasiswaMenu = new MahasiswaMenu();
                mahasiswaMenu.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfil editProfil = new EditProfil();
            this.Hide();
            editProfil.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
