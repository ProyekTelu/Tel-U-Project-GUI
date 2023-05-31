using System;
using System.Drawing;
using System.Windows.Forms;
using TelyuProject.Model;

namespace TelyuProject
{


    public partial class DosenMenu : Form
    {
    
        public DosenMenu()
        {
            InitializeComponent();
            CreateProject.Show();
            
            label3.Text = UserSession.currentDosenUser.first_name;
          
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.Top;
            }
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            UC_ListProject ucproject = new UC_ListProject();
            panelContent.Show();
            ucproject.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucproject);
            ucproject.BringToFront();

        }

        private void DosenMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListProject_Click(object sender, EventArgs e)
        {
            CreateProject.Show();
            UC_ListProject ucproject = new UC_ListProject();
            panelContent.Show();
            ucproject.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucproject);
            ucproject.BringToFront();
            dListProject.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dRequested.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = false;
            listProjectImageActive.Visible = true;
            requestedImageDed.Visible = true;
            requestedImageActive.Visible = false;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(29, 32, 62);
            panelRequested.BackColor = Color.FromArgb(50, 41, 93);
        }

        private void Requested_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_Requested ucreq = new UC_Requested();
            panelContent.Controls.Add(ucreq);
            dRequested.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = false;
            requestedImageActive.Visible = true;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(29, 32, 62);

        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            CreateProjectForm CPF = new CreateProjectForm();
            this.Hide();
            CPF.Show();
        }

        private void CreateProject_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 30; // Besar radius yang diinginkan

            // Menentukan sudut-sudut yang akan diberikan radius
            path.AddArc(button.ClientRectangle.Width - radius, 0, radius, radius, 270, 90); // sudut atas kanan
            path.AddArc(button.ClientRectangle.Width - radius, button.ClientRectangle.Height - radius, radius, radius, 0, 90); // sudut bawah kanan
            path.AddArc(0, button.ClientRectangle.Height - radius, radius, radius, 90, 90); // sudut bawah kiri
            path.AddArc(0, 0, radius, radius, 180, 90); // sudut atas kiri
            path.CloseFigure();

            button.Region = new System.Drawing.Region(path);
        }

        private void Project1_Click(object sender, EventArgs e)
        {
        }

        private void Project2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Profil bebas = new Profil();
            this.Hide();
            bebas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserSession.currentDosenUser = null;

            Login login = new Login();

            this.Hide();
            login.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Explore_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelRequested_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRequested_MouseClick(object sender, MouseEventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_Requested ucreq = new UC_Requested();
            panelContent.Controls.Add(ucreq);
            dRequested.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = false;
            requestedImageActive.Visible = true;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(29, 32, 62);
        }

        private void panelListProject_MouseClick(object sender, MouseEventArgs e)
        {

            CreateProject.Show();
            UC_ListProject ucproject = new UC_ListProject();
            panelContent.Show();
            ucproject.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(ucproject);
            ucproject.BringToFront();
            dListProject.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dRequested.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = false;
            listProjectImageActive.Visible = true;
            requestedImageDed.Visible = true;
            requestedImageActive.Visible = false;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(29, 32, 62);
            panelRequested.BackColor = Color.FromArgb(50, 41, 93);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void myProjectPanel_MouseClick(object sender, MouseEventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_MyProject uC_MyProject = new UC_MyProject();
            panelContent.Controls.Add(uC_MyProject);
            dMyProject.ForeColor = Color.White;
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            dRequested.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = true;
            myProjectImageDed.Visible = false;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = true;
            requestedImageActive.Visible = false;
            myProjectPanel.BackColor = Color.FromArgb(29, 32, 62);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(50, 41, 93);
        }

        private void listProjectImageActive_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_Requested ucreq = new UC_Requested();
            panelContent.Controls.Add(ucreq);
            dRequested.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = false;
            requestedImageActive.Visible = true;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(29, 32, 62);
        }

        private void listProjectImageDed_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_Requested ucreq = new UC_Requested();
            panelContent.Controls.Add(ucreq);
            dRequested.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = false;
            requestedImageActive.Visible = true;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(29, 32, 62);
        }

        private void requestedImageActive_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_Requested ucreq = new UC_Requested();
            panelContent.Controls.Add(ucreq);
            dRequested.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = false;
            requestedImageActive.Visible = true;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(29, 32, 62);
        }

        private void requestedImageDed_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_Requested ucreq = new UC_Requested();
            panelContent.Controls.Add(ucreq);
            dRequested.ForeColor = Color.White;
            dMyProject.ForeColor = Color.FromArgb(197, 190, 213);
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = false;
            myProjectImageDed.Visible = true;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = false;
            requestedImageActive.Visible = true;
            myProjectPanel.BackColor = Color.FromArgb(50, 41, 93);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(29, 32, 62);
        }

        private void dMyProject_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_MyProject uC_MyProject = new UC_MyProject();
            panelContent.Controls.Add(uC_MyProject);
            dMyProject.ForeColor = Color.White;
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            dRequested.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = true;
            myProjectImageDed.Visible = false;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = true;
            requestedImageActive.Visible = false;
            myProjectPanel.BackColor = Color.FromArgb(29, 32, 62);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(50, 41, 93);
        }

        private void myProjectImageActive_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_MyProject uC_MyProject = new UC_MyProject();
            panelContent.Controls.Add(uC_MyProject);
            dMyProject.ForeColor = Color.White;
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            dRequested.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = true;
            myProjectImageDed.Visible = false;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = true;
            requestedImageActive.Visible = false;
            myProjectPanel.BackColor = Color.FromArgb(29, 32, 62);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(50, 41, 93);
        }

        private void myProjectImageDed_Click(object sender, EventArgs e)
        {
            CreateProject.Hide();
            panelContent.Controls.Clear();
            UC_MyProject uC_MyProject = new UC_MyProject();
            panelContent.Controls.Add(uC_MyProject);
            dMyProject.ForeColor = Color.White;
            dListProject.ForeColor = Color.FromArgb(197, 190, 213);
            dRequested.ForeColor = Color.FromArgb(197, 190, 213);
            myProjectImageActive.Visible = true;
            myProjectImageDed.Visible = false;
            listProjectImageDed.Visible = true;
            listProjectImageActive.Visible = false;
            requestedImageDed.Visible = true;
            requestedImageActive.Visible = false;
            myProjectPanel.BackColor = Color.FromArgb(29, 32, 62);
            panelListProject.BackColor = Color.FromArgb(50, 41, 93);
            panelRequested.BackColor = Color.FromArgb(50, 41, 93);
        }

        private void panelKiri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
