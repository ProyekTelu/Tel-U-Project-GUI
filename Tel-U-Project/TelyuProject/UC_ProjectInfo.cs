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
    public partial class UC_ProjectInfo : UserControl
    {
        public UC_ProjectInfo(String projectName, String lecturer, String LecturerNip, String description, String major, String dates, String quota)
        {

            InitializeComponent();
            TProjectNama.Text = projectName;
            TDosen.Text = lecturer + " " + "(" + LecturerNip + ")";
            TDeskripsi.Text = description;
            TMajor.Text = major;
            TContract.Text = dates;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_ProjectInfo_Load(object sender, EventArgs e)
        {

        }

        private void TNip_Click(object sender, EventArgs e)
        {

        }

        private void TDosen_Click(object sender, EventArgs e)
        {

        }
    }
}
