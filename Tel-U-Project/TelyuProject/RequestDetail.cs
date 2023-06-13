using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelyuProject
{
    public partial class RequestDetail : Form
    {
        Requested req;

        public RequestDetail(Requested req)
        {
            InitializeComponent();
            this.req = req;
        }

        private void RequestDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Project project in Data.projectList)
            {
                if (project.Lecturer == req.lecturerName && project.LecturerNip == req.lecturerNip && project.Title == req.projectName)
                {
                    if (project.ListMahasiswa == null)
                    {
                        project.ListMahasiswa = new List<Mahasiswa>();
                    }
                    project.ListMahasiswa.Add(req.Mahasiswa);
                    project.quota -= 1;
                    if (project.quota == 0)
                    {
                        project.IsOpen = false;
                    }
                    Data.requestList.Remove(req);
                    MessageBox.Show("Berhasil menambahkan " + req.Mahasiswa.first_name + " " + req.Mahasiswa.last_name + " dengan NIM" + req.Mahasiswa.NIM + " ke Project " + project.Title);

                    string newProjectList = JsonConvert.SerializeObject(Data.projectList, Formatting.Indented);
                    File.WriteAllText("Project.json", newProjectList);
                    string newRequestList = JsonConvert.SerializeObject(Data.requestList, Formatting.Indented);
                    File.WriteAllText("DataRequested.json", newRequestList);
                    this.Close();


                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
