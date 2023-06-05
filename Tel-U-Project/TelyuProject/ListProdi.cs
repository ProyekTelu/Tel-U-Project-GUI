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


        public List<string> SelectedItems { get; set; }

        public ListProdi()
        {
            InitializeComponent();

            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

            SelectedItems = new List<string>();

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


            foreach (string item in checkedListBox1.CheckedItems)
            {
                // menambahkan nilai dari item yang di-check ke dalam variabel checkedItems
                SelectedItems.Add(item);
            }

            this.DialogResult = DialogResult.OK;


        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
