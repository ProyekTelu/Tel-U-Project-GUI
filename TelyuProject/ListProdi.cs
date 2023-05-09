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
    public partial class ListProdi : Form
    {
        public ListProdi()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

        }

        private void ListProdi_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void ListProdi_StyleChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
