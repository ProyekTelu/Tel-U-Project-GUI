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
    public partial class UC_MyProject : UserControl
    {
        public UC_MyProject()
        {
            InitializeComponent();

            
            foreach (Project project in Data.projectList)
            {
                if (UserSession<Dosen>.currentUser != null)
                {
                    if (project.LecturerNip == UserSession<Dosen>.currentUser.NIP)
                    {
                        String prodiStr = "";
                        foreach (String prodi in project.Prodi)
                        {
                            if (prodiStr == "")
                            {
                            prodiStr = prodi;
                            } else
                            {
                                prodiStr += " ," + prodi;
                            }
                        }
                        dataGridView1.Rows.Add(new object[]
                        {
                           project.Title, 
                           project.Lecturer, 
                            project.LecturerNip, 
                            project.Description,
                            prodiStr, 
                            project.StartDate + "-" + project.EndDate, 
                            project.quota,
                             project.IsDone ? "Completed" : (DateTime.Now.Date > project.StartDate.Date ? "In Progress" : (project.IsOpen ? "Recruitment Open" : "Recruitment Closed"))

                    }
                        ) ;
                    }
                } else if (UserSession<Mahasiswa>.currentUser != null)
                {

                }
                
            }
        }

        private void UC_MyProject_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
