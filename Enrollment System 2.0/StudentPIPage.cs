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
    public partial class StudentPIPage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        int age;
        DateTime birth;
        private readonly StudentDashboard studentdashboarddisplay;

        public string username { get; set; }
        public StudentPIPage(StudentDashboard studentuserdisplay)
        {
            InitializeComponent();
            studentdashboarddisplay = studentuserdisplay;
        }

        private void StudentPIPage_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void save_Click(object sender, EventArgs e)
        {
            birth = DateTime.Parse(dtpbday.Text);
            age = GetAge(birth);
            db.update_stud_info(username, txtfname.Text, txtmname.Text, txtlname.Text, txtphone.Text, txtgender.Text, DateTime.Parse(dtpbday.Text), Convert.ToInt32(age), txtaddress.Text, txtemail.Text);
            db.get_stud_info(username);
            MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK);
            DisplayData();
            studentdashboarddisplay.DisplayName();
            //homePage();
        }

        //public void homePage()
        //{
        //    studentdashboarddisplay.Controls.Clear();
        //    StudentHomePage homepage = new StudentHomePage();
        //    homepage.TopLevel = false;
        //    homepage.Dock = DockStyle.Fill;
        //    homepage.FormBorderStyle = FormBorderStyle.None;
        //    studentdashboarddisplay.Controls.Add(homepage);
        //    homepage.username = username;
        //    homepage.Show();
        //}

        static int GetAge(DateTime birth)
        {

            int age;
            if (birth.Month <= DateTime.Now.Month && birth.Day <= DateTime.Now.Day)
            {
                age = DateTime.Now.Year - birth.Year;
                Convert.ToInt32(age);
            }
            else
            {
                age = DateTime.Now.Year - birth.Year;
                age--;
                Convert.ToInt32(age);
            }

            return age;
        }
        public void DisplayData()
        {
            var result = db.get_stud_info(username);
            foreach (var item in result)
            {
                txtlname.Text = item.stud_lname;
                txtfname.Text = item.stud_fname;
                txtmname.Text = item.stud_mname;
                dtpbday.Text = item.stud_bd.ToString();
                txtphone.Text = item.stud_tel;
                txtgender.Text = item.stud_gender;
                txtemail.Text = item.stud_email;
                txtaddress.Text = item.stud_address;
            }
            txtuser.Text = txtfname.Text + " " + txtmname.Text + " " + txtlname.Text;
        }
    }
}
