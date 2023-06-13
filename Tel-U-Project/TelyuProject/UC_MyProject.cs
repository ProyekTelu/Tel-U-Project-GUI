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

            label1.Visible = false;
            dataGridView1.Visible = true;

            if (Data.projectList != null) { 
     
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

                        }) ;
                    }
                } else if (UserSession<Mahasiswa>.currentUser != null)
                {
                        if (project.ListMahasiswa != null && project.ListMahasiswa.Any(mahasiswa => mahasiswa.NIM == UserSession<Mahasiswa>.currentUser.NIM) )
                        {
                            String prodiStr = "";
                            foreach (String prodi in project.Prodi)
                            {
                                if (prodiStr == "")
                                {
                                    prodiStr = prodi;
                                }
                                else
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

                            });
                        }
                    }
                }
            } else
            {
                label1.Visible = true;
                dataGridView1.Visible = false;
                
                try
                {
                if (UserSession<Dosen>.currentUser != null && UserSession<Dosen>.currentUser.GetType().Equals(typeof(Dosen)))
                {
                    label1.Text = "You dont have project, \nDo you want to create a project? Click me";
                } else
                {
                    label1.Text = "You dont have project, Join project";
                }
                } catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void UC_MyProject_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Mendapatkan nilai dari baris yang diklik
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string projectName = row.Cells["TitleColumn"].Value.ToString();
                string lecturer = row.Cells["LectureColumn"].Value.ToString();
                string lecturerNip = row.Cells["LectureNipColumn"].Value.ToString();
                string description = row.Cells["DescriptionColumn"].Value.ToString();
                string major = row.Cells["MajorColumn"].Value.ToString();
                string contract = row.Cells["ContractColumn"].Value.ToString();
                string quota = row.Cells["QuotaColumn"].Value.ToString();

                // Membuat instance dari ProjectDetails dan meneruskan data yang diambil
                ProjectDetails projectDetails = new ProjectDetails(projectName, lecturer, lecturerNip, description, major, contract, quota);
                foreach(Project project in Data.projectList)
                {
                    if (project.Title.Equals(projectName))
                    {
                        ProjectSession.currentProject = project;
                    }
                }
                projectDetails.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (UserSession<Dosen>.currentUser != null) { 
                if (UserSession<Dosen>.currentUser.GetType() == typeof(Dosen))
                {
                    CreateProjectForm createProjectForm = new CreateProjectForm();
                    createProjectForm.ShowDialog();
                }
            }


        }
    }
}
