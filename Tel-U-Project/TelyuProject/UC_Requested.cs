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
    public partial class UC_Requested : UserControl
    {
        public UC_Requested()
        {
            InitializeComponent();
            if (Data.requestList != null)
            {
                foreach (Requested request in Data.requestList)
                {
                    if (request.lecturerNip == UserSession.currentDosenUser.NIP)
                    {
                        ListViewItem item = new ListViewItem(request.Mahasiswa.first_name + " " + request.Mahasiswa.last_name);
                        item.SubItems.Add(request.projectName);
                        item.SubItems.Add(request.notes);
                        item.SubItems.Add(request.Mahasiswa.email);
                        item.SubItems.Add(request.Mahasiswa.phone);
                        listView1.Items.Add(item);
                    }

                }

                listView1.ItemActivate += ListView1_ItemActivate;
            }
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                Requested reqProject = new Requested();
                foreach (Requested req in Data.requestList)
                {
                    if (req.projectName == selectedItem.SubItems[1].Text && req.Mahasiswa.first_name + " " + req.Mahasiswa.last_name == selectedItem.SubItems[0].Text)
                    {
                        reqProject = req;
                    }
                }

                // Show class based on item's data (replace with your own logic)
                RequestDetail projectDetails = new RequestDetail(reqProject);
                projectDetails.ShowDialog();
            }
        }
    }
}
