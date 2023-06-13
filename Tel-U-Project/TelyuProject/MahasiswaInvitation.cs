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
using TelyuProject.Model;

namespace TelyuProject
{
    public partial class MahasiswaInvitation : Form
    {
        public MahasiswaInvitation()
        {
            InitializeComponent();
            if (UserSession<Mahasiswa>.currentUser.invitations != null)
            {
                foreach (Invitation invitation in UserSession<Mahasiswa>.currentUser.invitations)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        invitation.dosen,
                        invitation.project,
                        invitation.description
                    });
                }
            }
            button1.Visible = false;
            button2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Yes Button
        {
            //Menambah mahasiswa dalam projek
            for (int i = 0; i < Data.projectList.Count; i++)
            {
                if (label2.Text.Substring(9).Equals(Data.projectList[i].Title))
                {
                    Data.projectList[i].ListMahasiswa.Add(UserSession<Mahasiswa>.currentUser);
                }
            }

            //Menhapus invations dalam mahasiswa
            try
            {
                for (int i = 0; i < Data.mahasiswaList.data.Count; i++)
                {
                    if (UserSession<Mahasiswa>.currentUser.first_name.Equals(Data.mahasiswaList.data[i].first_name))
                    {
                        for (int j = 0; j < Data.mahasiswaList.data[i].invitations.Count; j++)
                        {
                            if (Data.mahasiswaList.data[i].invitations[j].project.Equals(label2.Text.Substring(9)))
                            {
                                Data.mahasiswaList.data[i].invitations.RemoveAt(j);
                                UserSession<Mahasiswa>.currentUser.invitations.RemoveAt(j);
                            }
                        }
                        break;
                    }


                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            //menghapus row di grid pada view
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Projek"].Value != null && row.Cells["Projek"].Value.ToString().Equals(label2.Text.Substring(9)))
                {
                    dataGridView1.Rows.Remove(row);
                    break; // Exit the loop after removing the first occurrence
                }
            }

            string json_data_mahasiswa = JsonConvert.SerializeObject(Data.mahasiswaList.data, Formatting.Indented);
            File.WriteAllText("DataMahasiswa.json", json_data_mahasiswa);
            string json_data_projek = JsonConvert.SerializeObject(Data.projectList, Formatting.Indented);
            File.WriteAllText("Project.json", json_data_projek);

            MessageBox.Show("Projek Diterima");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label2.Text = "Projek : " + row.Cells["Projek"].Value.ToString();
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) // No Button
        {
            //Menhapus invations dalam mahasiswa
            for (int i = 0; i < Data.mahasiswaList.data.Count; i++)
            {
                if (UserSession<Mahasiswa>.currentUser.first_name.Equals(Data.mahasiswaList.data[i].first_name))
                {
                    for (int j = 0; j < Data.mahasiswaList.data[i].invitations.Count; j++)
                    {
                        if (Data.mahasiswaList.data[i].invitations[j].project.Equals(label2.Text.Substring(9)))
                        {
                            Data.mahasiswaList.data[i].invitations.RemoveAt(j);
                            UserSession<Mahasiswa>.currentUser.invitations.RemoveAt(j);
                        }
                    }
                    break;
                }
            }

            //menghapus row di grid pada view
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Projek"].Value != null && row.Cells["Projek"].Value.ToString().Equals(label2.Text.Substring(9)))
                {
                    dataGridView1.Rows.Remove(row);
                    break; // Exit the loop after removing the first occurrence
                }
            }

            string json_data_mahasiswa = JsonConvert.SerializeObject(Data.mahasiswaList.data, Formatting.Indented);
            File.WriteAllText("DataMahasiswa.json", json_data_mahasiswa);
            MessageBox.Show("Projek Ditolak");
        }
    }
}
