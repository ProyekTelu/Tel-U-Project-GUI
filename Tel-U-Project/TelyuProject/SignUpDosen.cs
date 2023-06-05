
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace TelyuProject
{
    public partial class SignUpDosen : Form
    {
        private String password;
        private Dosen dosen;
        public SignUpDosen(string password, Dosen dosen)
        {
            InitializeComponent();
            this.password = password;
            this.dosen = dosen;
        }

        private void Lnim_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            dosen.NIP = TEmployeeID.Text;
            dosen.phone = TPhone.Text;
            dosen.prodi = BMajor.GetItemText(BMajor.SelectedItem).ToString();
            dosen.fakultas = BFaculty.GetItemText(BFaculty.SelectedItem).ToString();
            dosen.kode_dosen = TLecCode.Text;
            dosen.gender = RGenderM.Checked ? "Laki-Laki" : "Perempuan";

            Data.dosenList.data.Add(dosen);
            Data.dosenList.password.Add(password);

            string json_data_mahasiswa = JsonConvert.SerializeObject(Data.dosenList.data, Formatting.Indented);
            File.WriteAllText("DataDosen.json", json_data_mahasiswa);
            string json_password_mahasiswa = JsonConvert.SerializeObject(Data.dosenList.password, Formatting.Indented);
            File.WriteAllText("PasswordDosen.json", json_password_mahasiswa);

            MessageBox.Show("Sign Up berhasil");
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void SignUpDosen_Load(object sender, EventArgs e)
        {

        }

        private void LBack_Click(object sender, EventArgs e)
        {

        }

        private void TEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
