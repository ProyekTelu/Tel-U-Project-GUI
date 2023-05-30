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
    public partial class MahasiswaMenu : Form
    {
        public MahasiswaMenu()
        {
            InitializeComponent();

            label3.Text =   UserSession.currentMhsUser.first_name;
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.Top;
            }
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            UC_ListProject ucproject = new UC_ListProject();
            panelContent.Show();
            ucproject.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucproject);
            ucproject.BringToFront();
        }

        private void MahasiswaMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Show();
        }

        private void Project1_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Profil objProfil = new Profil();
            this.Hide();
            objProfil.Show();
        }

        private void Project2_Click(object sender, EventArgs e)
        {
        }

        private void JoinProject_Click(object sender, EventArgs e)
        {
            RequestProject rp = new RequestProject("mahendra");
            rp.Show();
            this.Hide();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Show();
        }

        private void panelListProject_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelMyP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelKiri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMyProject_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            UC_MyProject uC_MyProject = new UC_MyProject();
            panelContent.Controls.Add(uC_MyProject);
            labelMyProject.ForeColor = Color.White;
            labelListProject.ForeColor = Color.FromArgb(197, 190, 213);
            LogoMyProjectActive.Visible = true;
            logoMyProjectDed.Visible = false;
            LogoListProjectDed.Visible = true;
            LogoListProjectActive.Visible = false;
            panelMyProject.BackColor = Color.FromArgb(29, 32, 62);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
        }

        private void labelListProject_Click(object sender, EventArgs e)
        {
            UC_ListProject ucproject = new UC_ListProject();
            panelContent.Show();
            ucproject.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucproject);
            ucproject.BringToFront();
            labelListProject.ForeColor = Color.White;
            labelMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            LogoMyProjectActive.Visible = false;
            logoMyProjectDed.Visible = true;
            LogoListProjectDed.Visible = false;
            LogoListProjectActive.Visible = true;
            panelMyProject.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(29, 32, 62);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
