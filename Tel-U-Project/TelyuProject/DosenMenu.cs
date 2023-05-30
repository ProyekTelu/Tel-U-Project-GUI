using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelyuProject
{


    public partial class DosenMenu : Form
    {
        private String username;
        public DosenMenu(String Username)
        {
            InitializeComponent();
            CreateProject.Show();
            DListProject.ForeColor = Color.DarkCyan;
            DRequested.ForeColor = Color.Black;
            DAccepted.ForeColor = Color.Black;
            
            label3.Text = Username;
            username = Username;
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
            panel1.Show();
            ucproject.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucproject);
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
            DListProject.ForeColor = Color.DarkCyan;
            DRequested.ForeColor = Color.Black;
            DAccepted.ForeColor = Color.Black;

            /*Button createProjectButton = new Button();

                     createProjectButton.Name = "CreateProjectButton";
                     createProjectButton.Text = "Create Project";
                     createProjectButton.Font = new Font("Montserrat",10, FontStyle.Bold);
                     createProjectButton.BackColor = Color.DodgerBlue;
                     createProjectButton.Location = new Point(426, 132);
                     createProjectButton.Anchor = AnchorStyles.None;
                     createProjectButton.Size = new Size(150, 40);
                     createProjectButton.ForeColor = Color.White;

                     this.Controls.Add(createProjectButton);*/

            CreateProject.Show();
            UC_ListProject ucproject = new UC_ListProject();
            panel1.Show();
            ucproject.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucproject);
            ucproject.BringToFront();
        }

        private void Requested_Click(object sender, EventArgs e)
        {
            DRequested.ForeColor = Color.DarkCyan;
            DListProject.ForeColor = Color.Black;
            DAccepted.ForeColor = Color.Black;
            CreateProject.Hide();
            panel1.Controls.Clear();
            UC_Requested ucreq = new UC_Requested();
            panel1.Controls.Add(ucreq);

        }

        private void Accepted_Click(object sender, EventArgs e)
        {
            DAccepted.ForeColor = Color.DarkCyan;
            DRequested.ForeColor = Color.Black;
            DListProject.ForeColor = Color.Black;
            CreateProject.Hide();
            panel1.Controls.Clear();
            UC_MyProject uC_MyProject = new UC_MyProject();
            panel1.Controls.Add(uC_MyProject);
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            CreateProjectForm CPF = new CreateProjectForm(username);
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
            string projectName = Project1.Text;
            ProjectDetails projectDetails = new ProjectDetails(projectName);
            projectDetails.Show();
        }

        private void Project2_Click(object sender, EventArgs e)
        {
            string projectName = Project2.Text;
            ProjectDetails projectDetails = new ProjectDetails(projectName);
            projectDetails.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Profil bebas = new Profil(username);
            this.Hide();
            bebas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
