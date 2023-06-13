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

            if (UserSession<Dosen>.currentUser != null)
            {
                EditFirstName.Text = UserSession<Dosen>.currentUser.first_name;
                EditLastName.Text = UserSession<Dosen>.currentUser.last_name;
                EditStudentID.Text = UserSession<Dosen>.currentUser.NIP;
                EditProfilEmail.Text = UserSession<Dosen>.currentUser.email;
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
           /* Mahasiswa mahasiswa = UserSession.currentMhsUser;

            mahasiswa.skills = EditSkill.Text;
            mahasiswa.looking_for = EditLookingFor.Text;


            UserSession.currentMhsUser = mahasiswa;

            string jsonUpdated = JsonConvert.SerializeObject(Data.mahasiswaList, Formatting.Indented);
            File.WriteAllText("DataMahasiswa.json", jsonUpdated);

            */
            MessageBox.Show("Edit Profil Suceed");
            Profil profil = new Profil();
            profil.Show();
            this.Close();
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
    }
}
