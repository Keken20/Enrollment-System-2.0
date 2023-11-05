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
    public partial class AdminSubjectPage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminSubjectPage()
        {
            InitializeComponent();
        }

        private void AdminSubjectPage_Load(object sender, EventArgs e)
        {
            var course = db.get_course().ToList();
            comboBox1.DataSource = course;
            comboBox1.DisplayMember = "course_name";
            comboBox1.ValueMember = "course_id";
            dataGridView1.DataSource = db.view_subject();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int courseid = (int)comboBox1.SelectedValue;
            string subjectcode = subcode.Text.ToString();
            string subjectname = subname.Text.ToString();
            int sublevel = Convert.ToInt32(subyear.SelectedItem.ToString());
            int subunit = Convert.ToInt32(subunits.Text);


            if (subcode.Text == "" || subname.Text == "" || subunits.Text == "")
            {
                MessageBox.Show("Input needed informations");
                ;
            }
            else
            {
                MessageBox.Show("Subject added successfully", "Message");
                db.add_subject(subjectcode, subjectname, subunit, sublevel, courseid);
                ClearData();
                dataGridView1.DataSource = db.view_subject();
            }
        }
        private void ClearData()
        {
            subcode.Text = "";
            subname.Text = "";
            subunits.Text = "";
            subyear.Text = "";
        }
    }
}
