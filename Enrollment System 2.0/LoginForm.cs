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
    public partial class LoginForm : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin")
            {
                int user = db.check_username(username.Text).Count();
                int pass = db.check_password(username.Text, password.Text).Count();
                if (IsEmpty() == true)
                {
                    MessageBox.Show("Enter username and password first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user <= 0)
                {
                    MessageBox.Show("Invalid username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass <= 0)
                {
                    MessageBox.Show("Invalid password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAdminDashboard();
                }
            }
            else
            {
                int user = db.check_studentacc(username.Text).Count();
                int pass = db.check_studentpass(username.Text, password.Text).Count();
                if (IsEmpty() == true)
                {
                    MessageBox.Show("Enter username and password first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user <= 0)
                {
                    MessageBox.Show("Invalid username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass <= 0)
                {
                    MessageBox.Show("Invalid password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowStudentDashboard();
                }
            }
        }
        bool IsEmpty()
        {
            if (username.Text == "" || password.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ShowAdminDashboard()
        {
            string user_name = username.Text;
            AdminDashboad f2 = new AdminDashboad();
            f2.Show();
            Visible = false;
        }

        private void ShowStudentDashboard()
        {
            StudentDashboard f4 = new StudentDashboard();
            f4.username = username.Text;
            f4.Show();
            Visible = false;
        }

        private void create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            Visible = false;
        }
    }
}
