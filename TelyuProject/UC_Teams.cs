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
    public partial class UC_Teams : UserControl
    {
        public UC_Teams()
        {
            InitializeComponent();
            addTeam1();
            addTeam2();
        }

        private void addTeam1()
        {
            tableTeam.Rows.Add(
                new object[]
                {
                    "Reza Adhie Dharmawan",
                    1302213016,
                    "S1 Rekayasa Perangkat Lunak"
                }
            );
            tableTeam.Rows.Add(
                new object[]
                {
                    "Fasya Rahim Maulahir",
                    1302213116,
                    "S1 Rekayasa Perangkat Lunak"
                }
            );
            tableTeam.Rows.Add(
                new object[]
                {
                    "Muhammad Zaky Mufasa",
                    1302213169,
                    "S1 Rekayasa Perangkat Lunak"
                }
            );
        }

        private void addTeam2()
        {
            tableTeam2.Rows.Add(
                new object[]
                {
                    "Callista Putri",
                    1302213112,
                    "S1 Sistem Informasi"
                }
            );
        }

        private void team1_Click(object sender, EventArgs e)
        {

        }

        private void tableTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
