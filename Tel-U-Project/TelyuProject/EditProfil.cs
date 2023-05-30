using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelyuProject
{
    public partial class EditProfil : Form
    {

        public string username;
        public EditProfil(string username)
        {
            InitializeComponent();
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
            Profil profil = new Profil(username);
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
