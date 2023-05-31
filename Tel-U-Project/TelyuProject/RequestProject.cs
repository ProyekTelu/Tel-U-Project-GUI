using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using TelyuProject.Model;
using Newtonsoft.Json;

namespace TelyuProject
{
    public partial class RequestProject : Form
    {
        private string dosenName;
        private string dosenNip;
        private string destinationFilePath;
        private string projectName;
        Requested request = new Requested();
        public RequestProject(String dosenName, String projectName, String dosenNip)
        {
            InitializeComponent();
            this.dosenName = dosenName;
            this.projectName = projectName;
            this.dosenNip = dosenNip;
            labelStudentName.Text = UserSession.currentMhsUser.first_name+" "+UserSession.currentMhsUser.last_name;
            labelLecturerName.Text = dosenName;
            EmailTextBox.Text = UserSession.currentMhsUser.email;
            textBoxPhoneNumber.Text = UserSession.currentMhsUser.phone;
            txtFilePath.ReadOnly = true;
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lNamaDosen_Click(object sender, EventArgs e)
        {

        }

        private void lNamaMhs_Click(object sender, EventArgs e)
        {

        }

        private void Temail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tnophone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Bupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Microsoft Word Documents (*.doc;*.docx)|*.doc;*.docx|PDF Files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Microsoft Word Documents (*.doc;*.docx)|*.doc;*.docx|PDF Files (*.pdf)|*.pdf";
                saveFileDialog.FileName = Path.GetFileName(filePath);
                MessageBox.Show("File uploaded successfully.");

                string fileName = Path.GetFileName(filePath);
                txtFilePath.Text = fileName;
                string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UploadedFiles");
                destinationFilePath = Path.Combine(targetDirectory, fileName);
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }
                File.Copy(filePath, destinationFilePath, true);
            }
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RequestProject_Load(object sender, EventArgs e)
        {
       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            request.lecturerName = dosenName;
            request.lecturerNip = dosenNip;
            request.notes = textBoxNotes.Text;
            request.cvDirectory = destinationFilePath;
            request.Mahasiswa = (UserSession.currentMhsUser);
            request.projectName = projectName;
            if (Data.requestList == null)
            {
                Data.requestList = new List<Requested>();
            }
            Data.requestList.Add(request);

            string json_data_requested = JsonConvert.SerializeObject(Data.requestList, Formatting.Indented);
            File.WriteAllText("DataRequested.json", json_data_requested);

            MessageBox.Show("Request Sent!");
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Tphoneno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                if (textBoxPhoneNumber.Text.Length >= 12)
                {
                    e.Handled = true;
                }
            }


        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
