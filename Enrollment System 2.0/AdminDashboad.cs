using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System_2._0
{
    public partial class AdminDashboad : Form
    {
        public AdminDashboad()
        {
            InitializeComponent();
        }
        private void AdminDashboad_Load(object sender, EventArgs e)
        {
            timer1.Start();
            AdminHomePage homepage = new AdminHomePage();
            homepage.TopLevel = false;
            homepage.Dock = DockStyle.Fill;
            homepage.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(homepage);
            homepage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            AdminHomePage homepage = new AdminHomePage();
            homepage.TopLevel = false;
            homepage.Dock = DockStyle.Fill;
            homepage.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(homepage);
            homepage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            AdminEnrolleesPage enrollees = new AdminEnrolleesPage();
            enrollees.TopLevel = false;
            enrollees.Dock = DockStyle.Fill;
            enrollees.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(enrollees);
            enrollees.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            AdminSubjectPage sp = new AdminSubjectPage();
            sp.TopLevel = false;
            sp.Dock = DockStyle.Fill;
            sp.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(sp);
            sp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            AdminStudentPage sp = new AdminStudentPage();
            sp.TopLevel = false;
            sp.Dock = DockStyle.Fill;
            sp.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(sp);
            sp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            AdminInstructorPage sp = new AdminInstructorPage();
            sp.TopLevel = false;
            sp.Dock = DockStyle.Fill;
            sp.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(sp);
            sp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoginForm i = new LoginForm();
            i.Show();
            i.BringToFront();
            Visible = false;
            MessageBox.Show("Successfully Logged Out!", "Log Out", MessageBoxButtons.OK);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            AdminSectionPage sp = new AdminSectionPage();
            sp.TopLevel = false;
            sp.Dock = DockStyle.Fill;
            sp.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(sp);
            sp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }
    }
}
