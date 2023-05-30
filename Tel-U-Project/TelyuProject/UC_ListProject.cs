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
    public partial class UC_ListProject : UserControl
    {
        public string strProdi;
        public UC_ListProject()
        {
            InitializeComponent();

            // Add sample items to the ListView
            foreach (Project project in Data.projectList)
            {
                ListViewItem item = new ListViewItem(project.Title);
                item.SubItems.Add(project.Lecturer);
                item.SubItems.Add(project.Description);
                string strProdi = string.Join(", ", project.Prodi);
                item.SubItems.Add(strProdi);
                item.SubItems.Add(project.StartDate.ToString("dd/MM/yyyy") + " - " + project.EndDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(project.quota.ToString());
                listView1.Items.Add(item);
            }

            // Hook up event handler
            listView1.ItemActivate += ListView1_ItemActivate;

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
                string description = selectedItem.SubItems[2].Text;
                string prodi = selectedItem.SubItems[3].Text;
                string dates = selectedItem.SubItems[4].Text;
                string quota = selectedItem.SubItems[5].Text;

                // Show class based on item's data (replace with your own logic)
                ProjectDetails projectDetails = new ProjectDetails(title,lecturer,description,prodi,dates, quota);
                projectDetails.ShowDialog();
            }
        }
    }
}
