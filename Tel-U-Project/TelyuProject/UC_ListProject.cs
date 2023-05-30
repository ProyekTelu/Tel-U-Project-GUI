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


            foreach (Project project in Data.projectList)
            {
                ListViewItem item = new ListViewItem(project.Title);
                item.SubItems.Add(project.Lecturer);
                item.SubItems.Add(project.Description);
                strProdi = "";
                foreach (string a in project.Prodi)
                {
                    strProdi = strProdi + a + ", ";
                }
                item.SubItems.Add(strProdi);
                item.SubItems.Add(project.StartDate.ToString("dd/MM/yyyy") + " - " + project.EndDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(project.quota.ToString());
                listView1.Items.Add(item);
            }                       

        }

        private void UC_ListProject_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
