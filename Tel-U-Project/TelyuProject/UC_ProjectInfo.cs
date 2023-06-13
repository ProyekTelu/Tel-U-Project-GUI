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
    public partial class UC_ProjectInfo : UserControl
    {
        public UC_ProjectInfo(String projectName, String lecturer, String LecturerNip, String description, String major, String dates, String quota)
        {

            InitializeComponent();
            TProjectNama.Text = projectName;
            TDosen.Text = lecturer + " " + "(" + LecturerNip + ")";
            TDeskripsi.Text = description;
            TMajor.Text = major;
            TContract.Text = dates;



            if (UserSession<Mahasiswa>.currentUser == null)
            {
            foreach (Project project in Data.projectList)
            {
                if (project.Title == projectName)
                {
                    if (UserSession<Dosen>.currentUser != null)
                    {
                        if (project.Lecturer == UserSession<Dosen>.currentUser.first_name)
                        {
                            button1.Visible = true;
                            if (project.quota == 0)
                                {
                                    button1.Visible = false;
                                }
                            linkLabel1.Visible = true;
                            LinkGroup.Visible = true;
                            linkLabel1.Text = project.linkGroup;
                            break;
                        }
                    }
                    
                }
            }    
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_ProjectInfo_Load(object sender, EventArgs e)
        {

        }

        private void TNip_Click(object sender, EventArgs e)
        {

        }

        private void TDosen_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkGroup_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InviteMahasiswa inviteMahasiswa = new InviteMahasiswa();
            inviteMahasiswa.Show();
        }
    }
}
