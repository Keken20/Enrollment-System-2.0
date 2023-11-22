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
    public partial class StudentHomePage : Form
    {
        public string username { get; set; }
        int stud_id;
        string status;

        EnrollmentDataContext db = new EnrollmentDataContext();

        public StudentHomePage()
        {
            InitializeComponent();
        }

        private void StudentHomePage_Load(object sender, EventArgs e)
        {
            var result = db.get_id(username).ToList();
            foreach (var item in result)
            {
                stud_id = Convert.ToInt32(item.stud_id.ToString());
            }

            var res = db.get_status(stud_id).ToList();
            foreach (var item in res)
            {
                status = item.enrollment_status.ToString();
            }

            if (status == "Accepted")
            {
                enroll_status.Text = status;
                var crs = db.get_course_info(stud_id).ToList();
                foreach (var item in crs)
                {
                    course.Text = item.section_course.ToString();
                    section.Text = item.section_yearlevel.ToString() + " - " + item.section_name.ToString();
                }
            }
            else
            {
                enroll_status.Text = "Pending";
                course.Text = "N/A";
                section.Text = "N/A";
            }
        }


    }
}
