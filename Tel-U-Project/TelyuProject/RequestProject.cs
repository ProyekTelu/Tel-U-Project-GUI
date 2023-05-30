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

namespace TelyuProject
{
    public partial class RequestProject : Form
    {
        public string username, dosen;
        public RequestProject(String username, String dosen)
        {
            InitializeComponent();
            this.username = username;
            this.dosen = dosen;
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
            MahasiswaMenu mahasiswamenu = new MahasiswaMenu(username);
            mahasiswamenu.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MahasiswaMenu mahasiswamenu = new MahasiswaMenu(username);
            mahasiswamenu.Show();
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
                if (textBox1.Text.Length >= 12)
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
    }
}
