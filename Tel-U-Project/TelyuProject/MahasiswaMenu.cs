using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TelyuProject
{
    public partial class MahasiswaMenu : Form
    {
        public MahasiswaMenu(String Username)
        {

            InitializeComponent();
            MListProject.ForeColor = Color.DarkCyan;
            MAccepted.ForeColor = Color.Black;
            label3.Text = Username;
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.Top;
            }


            UC_ListProject ucproject = new UC_ListProject();
            panel1.Show();
            ucproject.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucproject);
            ucproject.BringToFront();
        }

        private void MListProject_Click(object sender, EventArgs e)
        {
            MListProject.ForeColor = Color.DarkCyan;
            MAccepted.ForeColor = Color.Black;

            /*Button createProjectButton = new Button();

                     createProjectButton.Name = "CreateProjectButton";
                     createProjectButton.Text = "Create Project";
                     createProjectButton.Font = new Font("Montserrat",10, FontStyle.Bold);
                     createProjectButton.BackColor = Color.DodgerBlue;
                     createProjectButton.Location = new Point(426, 132);
                     createProjectButton.Anchor = AnchorStyles.None;
                     createProjectButton.Size = new Size(150, 40);
                     createProjectButton.ForeColor = Color.White;

                     this.Controls.Add(createProjectButton);*/

            UC_ListProject ucproject = new UC_ListProject();
            panel1.Show();
            ucproject.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucproject);
            ucproject.BringToFront();

        }

        private void Requested_Click(object sender, EventArgs e)
        {
        }

        private void MAccepted_Click(object sender, EventArgs e)
        {
            MAccepted.ForeColor = Color.DarkCyan;
            MListProject.ForeColor = Color.Black;
            panel1.Controls.Clear();
            UC_MyProject uC_MyProject = new UC_MyProject();
            panel1.Controls.Add(uC_MyProject);
        }

        private void Project2_Click(object sender, EventArgs e)
        {
            string projectName = Project2.Text;
            ProjectDetails projectDetails = new ProjectDetails(projectName);
            projectDetails.Show();
        }

        private void Project1_Click(object sender, EventArgs e)
        {
            string projectName = Project1.Text;
            ProjectDetails projectDetails = new ProjectDetails(projectName);
            projectDetails.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestProject rp = new RequestProject(label3.Text, "mahendra");
            rp.Show();
            this.Hide();
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
    }
}
