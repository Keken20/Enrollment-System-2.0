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
    public partial class StudentDashboard : Form
    {
        public string username { get; set; }
        public StudentDashboard()
        {
            InitializeComponent();
        }
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
           StudentHomePage homepage = new StudentHomePage();
           homepage.TopLevel = false;
           homepage.Dock = DockStyle.Fill;
           homepage.FormBorderStyle = FormBorderStyle.None;
           studentpanel.Controls.Add(homepage);
           homepage.username = username;
           homepage.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            studentpanel.Controls.Clear();
            StudentHomePage homepage = new StudentHomePage();
            homepage.TopLevel = false;
            homepage.Dock = DockStyle.Fill;
            homepage.FormBorderStyle = FormBorderStyle.None;
            studentpanel.Controls.Add(homepage);
            homepage.username = username;
            homepage.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentpanel.Controls.Clear();
            StudentEnrollmentPage homepage = new StudentEnrollmentPage();
            homepage.TopLevel = false;
            homepage.Dock = DockStyle.Fill;
            homepage.FormBorderStyle = FormBorderStyle.None;
            studentpanel.Controls.Add(homepage);
            homepage.username = username;
            homepage.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentpanel.Controls.Clear();
            StudentCORPage homepage = new StudentCORPage();
            homepage.TopLevel = false;
            homepage.Dock = DockStyle.Fill;
            homepage.FormBorderStyle = FormBorderStyle.None;
            studentpanel.Controls.Add(homepage);
            homepage.username = username;
            homepage.Show();      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentpanel.Controls.Clear();
            StudentPIPage homepage = new StudentPIPage();
            homepage.TopLevel = false;
            homepage.Dock = DockStyle.Fill;
            homepage.FormBorderStyle = FormBorderStyle.None;
            studentpanel.Controls.Add(homepage);
            homepage.username = username;
            homepage.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoginForm i = new LoginForm();
            i.Show();
            i.BringToFront();
            Visible = false;
            MessageBox.Show("Successfully Logged Out!", "Log Out", MessageBoxButtons.OK);
        }
    }
}
