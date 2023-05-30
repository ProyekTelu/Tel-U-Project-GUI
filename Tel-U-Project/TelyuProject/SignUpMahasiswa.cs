using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;


namespace TelyuProject
{
    public partial class SignUpMahasiswa : Form
    {
        private String password;
        private Mahasiswa mahasiswa;
        public SignUpMahasiswa(String password, Mahasiswa mahasiswa)
        {
            InitializeComponent();
            this.password = password;
            this.mahasiswa = mahasiswa;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            mahasiswa.NIM = TStudentID.Text;
            mahasiswa.phone = TPhone.Text;
            mahasiswa.prodi = BMajor.GetItemText(BMajor.SelectedItem).ToString();
            mahasiswa.fakultas = BFaculty.GetItemText(BFaculty.SelectedItem).ToString();
            mahasiswa.gender = RGenderM.Checked ? "Laki-Laki" : "Perempuan";
            
            Data.mahasiswaList.data.Add(mahasiswa);
            Data.mahasiswaList.password.Add(password);
            
            string json_data_mahasiswa = JsonConvert.SerializeObject(Data.mahasiswaList.data, Formatting.Indented);
            File.WriteAllText("DataMahasiswa.json", json_data_mahasiswa);
            string json_password_mahasiswa = JsonConvert.SerializeObject(Data.mahasiswaList.password, Formatting.Indented);
            File.WriteAllText("PasswordMahasiswa.json", json_password_mahasiswa);
            
            MessageBox.Show("Sign Up berhasil");
            Login login = new Login();
            login.Show();
            this.Hide();

        }
        private void LBack_Click(object sender, EventArgs e)
        {
            

        }

        private void SignUpMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void TStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void RGenderM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RGenderFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
