using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelyuProject
{
    public partial class DosenMenu : Form
    {

        public DosenMenu(String Username)
        {
            InitializeComponent();
            label3.Text = Username;
            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.None;
            }

            foreach (Control control in Controls)
            {
                control.Anchor = AnchorStyles.Top;
            }
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
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
        }

        private void Requested_Click(object sender, EventArgs e)
        {
            DRequested.ForeColor = Color.DarkCyan;
            DListProject.ForeColor = Color.Black;
            DAccepted.ForeColor = Color.Black;
            CreateProject.Hide();

        }

        private void Accepted_Click(object sender, EventArgs e)
        {
            DAccepted.ForeColor = Color.DarkCyan;
            DRequested.ForeColor = Color.Black;
            DListProject.ForeColor = Color.Black;
            CreateProject.Hide();
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            CreateProjectForm CPF = new CreateProjectForm();
            CPF.ShowDialog();
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
