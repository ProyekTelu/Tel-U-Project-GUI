using Newtonsoft.Json;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelyuProject
{
    public partial class InviteMahasiswa : Form
    {
        public InviteMahasiswa()
        {
            InitializeComponent();
            if(Data.mahasiswaList.data != null)
            {
                foreach (Mahasiswa mahasiswa in Data.mahasiswaList.data)
                {
  
                    dataGridView1.Rows.Add(new object[]
                    {
                        mahasiswa.first_name + " " + mahasiswa.last_name,
                        mahasiswa.prodi,                       
                        mahasiswa.phone
                    });
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label2.Text = "Nama : " + row.Cells["nama"].Value.ToString();
            label4.Text = "Prodi : " + row.Cells["prodi"].Value.ToString();
            label5.Text = "Kontak : " + row.Cells["kontak"].Value.ToString();
        }

        private void InviteMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nama = label2.Text.Substring(7);
            MessageBox.Show("User berhasil diinvite");
            for (int i = 0;  i < Data.mahasiswaList.data.Count; i++)
            {
                if (nama.Equals(Data.mahasiswaList.data[i].first_name + " " + Data.mahasiswaList.data[i].last_name))
                {
                    Data.mahasiswaList.data[i].invitations.Add(new Model.Invitation(Model.ProjectSession.currentProject.Title, Model.UserSession<Dosen>.currentUser.first_name + " " + Model.UserSession<Dosen>.currentUser.last_name, textBox1.Text));
                    string json_data_mahasiswa = JsonConvert.SerializeObject(Data.mahasiswaList.data, Formatting.Indented);
                    File.WriteAllText("DataMahasiswa.json", json_data_mahasiswa);
                    break;
                }
            }
        }
    }
}
