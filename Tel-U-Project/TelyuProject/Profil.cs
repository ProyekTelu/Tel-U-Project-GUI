﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TelyuProject
{
    public partial class Profil : Form
    {

        public Profil()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }

        private void Profil_StyleChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DosenMenu dosenMenu = new DosenMenu();
            dosenMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfil editProfil = new EditProfil();
            this.Hide();
            editProfil.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
