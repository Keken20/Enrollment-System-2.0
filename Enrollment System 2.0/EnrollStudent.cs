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
    public partial class EnrollStudent : Form
    {
        private readonly AdminEnrolleesPage adminEnrolleesDisplay;  
        EnrollmentDataContext db = new EnrollmentDataContext();
        public int studentid{ get; set; }
        int enrollmentid;
        public EnrollStudent(AdminEnrolleesPage AdEnrolData)
        {
            InitializeComponent();
            adminEnrolleesDisplay = AdEnrolData;
        }
 

        private void EnrollStudent_Load(object sender, EventArgs e)
        {
            var result = db.get_stud(studentid);
            foreach (var item in result)
            {
                Info.Text = item.stud_fname + " " + item.stud_mname + " " + item.stud_lname;
                tbcourse.Text = item.course_name;
                tbyrlv.Text = item.enrollment_yearlevel;
                enrollmentid =item.enrollment_id;
            }
            comboBox1.DataSource = db.enroll_stud_section(tbcourse.Text, tbyrlv.Text);
            comboBox1.DisplayMember = "section_name";
            comboBox1.ValueMember = "section_id";
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Select section to enroll", "Message");
            }
            else
            {
                db.accept_enrollment(enrollmentid, studentid, Convert.ToInt32(comboBox1.SelectedValue));
                db.update_status(studentid);
                MessageBox.Show("Sucessfully enrolled", "Message");
                adminEnrolleesDisplay.DisplayData();
                Close();
            }                
        }
    }
}
