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
    public partial class UC_ListProject : UserControl
    {
        public string strProdi;
        public int empty = 0;
        public UC_ListProject()
        {
            InitializeComponent();
            empty = 0;
            try
            {
                if (Data.projectList != null)
                {
                    foreach (Project project in Data.projectList)
                    {
                        if (project.quota != 0 )
                        {
                            ListViewItem item = new ListViewItem(project.Title);
                            item.SubItems.Add(project.Lecturer);
                            item.SubItems.Add(project.LecturerNip);
                            item.SubItems.Add(project.Description);
                            string strProdi = string.Join(", ", project.Prodi);
                            item.SubItems.Add(strProdi);
                            item.SubItems.Add(project.StartDate.ToString("dd/MM/yyyy") + " - " + project.EndDate.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(project.quota.ToString());
                            listView1.Items.Add(item);
                            empty++;
                        }
                    }


                    listView1.ItemActivate += ListView1_ItemActivate;
                }
                if (empty == 0)
                {
                    listView1.Visible = false;
                    emptyAnnounceProject.Visible = true;
                    existProjectLabel.Visible = false;
                }
                if (empty > 0)
                {
                    if (UserSession<Dosen>.currentUser != null && UserSession<Dosen>.currentUser.GetType() == typeof(Dosen))
                    {
                        existProjectLabel.Visible = true;
                        existProjectLabel.Text = "*Double Click project title to see the detail";
                    }
                    else
                    {
                        existProjectLabel.Visible = true;
                    }
                    listView1.Visible = true;
                    emptyAnnounceProject.Visible = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        private void UC_ListProject_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string title = selectedItem.SubItems[0].Text;
                string lecturer = selectedItem.SubItems[1].Text;
                string LecturerNip = selectedItem.SubItems[2].Text;
                string description = selectedItem.SubItems[3].Text;
                string prodi = selectedItem.SubItems[4].Text;
                string dates = selectedItem.SubItems[5].Text;
                string quota = selectedItem.SubItems[6].Text;

                // Show class based on item's data (replace with your own logic)
                ProjectDetails projectDetails = new ProjectDetails(title, lecturer, LecturerNip, description, prodi, dates, quota);
                projectDetails.ShowDialog();
            }
        }

        private void emptyAnnounceProject_Click(object sender, EventArgs e)
        {

        }

        private void existProjectLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
