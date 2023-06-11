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

namespace TelyuProject
{
    public partial class ProjectDetails : Form
    {

        String projectName;
        String lecturer;
        String description;
        String LecturerNip;
        String major;
        String dates;
        String quota;
        bool mahasiswaAlreadyInProject = false;
        bool mahasiswaOnRequest = false;

        public ProjectDetails(String projectName, String lecturer, String LecturerNip, String description, String major, String dates, String quota)
        {
            InitializeComponent();
            if (UserSession<Dosen>.currentUser != null && UserSession<Dosen>.currentUser.GetType() == typeof(Dosen))
            {
                JoinProject.Visible = false;
            }


            if (UserSession<Mahasiswa>.currentUser != null)
            {
                foreach (Project project in Data.projectList)
                {
                    if (project.LecturerNip == LecturerNip && project.Title == projectName)
                    {

                       if (project.ListMahasiswa != null)
                         {
                             mahasiswaAlreadyInProject = project.ListMahasiswa.Contains(UserSession<Mahasiswa>.currentUser) ? true : false;
                             break;
                         }
                        

                    }
                }
            }
            

            foreach (Requested req in Data.requestList)
            {
                if (req.projectName == projectName && req.Mahasiswa.Equals(UserSession<Mahasiswa>.currentUser)) {
                    mahasiswaOnRequest = true;
                    break;
                }
            }

            if (mahasiswaAlreadyInProject)
            {
                JoinProject.Text = "You're already in this project";
                JoinProject.Enabled = false;
            }

            if (mahasiswaOnRequest)
            {
                JoinProject.Text = "On Request";
                JoinProject.Enabled = false;
            }
            
            this.projectName = projectName;
            this.lecturer = lecturer;
            this.LecturerNip = LecturerNip;
            this.description = description;
            this.major = major;
            this.dates = dates;
            this.quota = quota;
            panelContainer.Hide();
            LInfo_Click(this, new EventArgs());
            label1.Text = projectName;
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }
            UC_ProjectInfo uc = new UC_ProjectInfo(projectName, lecturer, LecturerNip, description, major, dates, quota);
            addUserControl(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {

        }

        private void ProjectDetails_StyleChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }
        }

        private void LTeams_Click(object sender, EventArgs e)
        {
            panelContainer.Show();
           
            UC_Teams uc = new UC_Teams(projectName, LecturerNip);
            addUserControl( uc );


        }

        private void LInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Show();
            UC_ProjectInfo uc = new UC_ProjectInfo(projectName,lecturer,LecturerNip, description, major,dates,quota);
            addUserControl(uc);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectDetails_Shown(object sender, EventArgs e)
        {

        }


        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add( userControl );
            userControl.BringToFront();
        }

        private void JoinProject_Click(object sender, EventArgs e)
        {
            RequestProject requestProject = new RequestProject(lecturer,projectName, LecturerNip);
            requestProject.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
