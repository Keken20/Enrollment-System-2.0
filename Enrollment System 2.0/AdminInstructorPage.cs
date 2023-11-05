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
    public partial class AdminInstructorPage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminInstructorPage()
        {
            InitializeComponent();
        }

        private void AdminInstructorPage_Load(object sender, EventArgs e)
        {
            var subject = db.get_subject().ToList();
            dataGridView1.DataSource = db.view_instructor();
            comboBox1.DataSource = subject;
            comboBox1.DisplayMember = "subject_name";
            comboBox1.ValueMember = "subject_id";
        }

        private void add_Click(object sender, EventArgs e)
        {
            string insfname = instructorfname.Text;
            string inslname = instructorlname.Text;
            int subid = Convert.ToInt32(comboBox1.SelectedValue);
            if (instructorfname.Text == "" || instructorlname.Text == "")
            {
                MessageBox.Show("Fill all informations");
            }
            else
            {
                MessageBox.Show("Subject added sucessfully", "Message");
                db.add_instructor(insfname, inslname, subid);
                dataGridView1.DataSource = db.view_instructor();
                ClearData();
            }
        }
        private void ClearData()
        {
            instructorfname.Text = "";
            instructorlname.Text = "";
        }
    }
}
