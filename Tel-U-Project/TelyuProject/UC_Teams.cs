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
    public partial class UC_Teams : UserControl
    {

        private String projectName;
        private String nip;

        public UC_Teams(String projectName, String nip)
        {
            InitializeComponent();
            this.projectName = projectName;
            this.nip = nip;
            addTeam1();
        }

        private void addTeam1()
        {
            Project currentProject = null;
            foreach(Project project in Data.projectList)
            {
                if (project.Title == projectName && project.LecturerNip == nip)
                {
                    currentProject = project;
                }
            }

            foreach(Mahasiswa mahasiswa in currentProject.ListMahasiswa)
            {
                tableTeam.Rows.Add(
                     new object[]
                {
                    mahasiswa.first_name + " " + mahasiswa.last_name,
                    mahasiswa.NIM,
                    mahasiswa.prodi
                }
            );
            }
        }

        private void team1_Click(object sender, EventArgs e)
        {

        }

        private void tableTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableTeam2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
