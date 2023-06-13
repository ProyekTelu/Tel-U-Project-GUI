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
            label1.Text = req.Mahasiswa.first_name + " " + req.Mahasiswa.last_name;
            label6.Text = req.Mahasiswa.NIM;
            label7.Text = req.Mahasiswa.prodi;
            textBox1.Text = req.notes;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.requestList.RemoveAll(r => r.projectName == req.projectName && r.Mahasiswa.NIM == req.Mahasiswa.NIM);
            MessageBox.Show("Berhasil menolak mahasiswa " + req.Mahasiswa.first_name);
            Application.Exit();
            DosenMenu dosenmenu = new DosenMenu();
            dosenmenu.Show();
        }
    }
}
