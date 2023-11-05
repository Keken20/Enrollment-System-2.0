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
    public partial class AdminSchedulePage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        string sub;
        public int sectionid { get; set; }
        public AdminSchedulePage()
        {
            InitializeComponent();
        }

        private void AdminSchedulePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.view_schedule(sectionid);
            var section = db.get_section_info(sectionid);
            foreach(var item in section)
            {
                txtsection.Text = item.section_course+ " " + item.section_yearlevel + "-" + item.section_name;
            }
            var subject = db.get_subject().ToList();
            comboBox1.DataSource = subject;
            comboBox1.DisplayMember = "subject_name";
            comboBox1.ValueMember = "subject_id";          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int subid = Convert.ToInt32(comboBox1.SelectedValue);
            var result = db.get_sub_info(subid);
            foreach(var item in result)
            {
                sub = item.subject_name;
            }
            db.add_schedule(txbsection.Text,sub,txbtime.Text,txbday.Text,txbday.Text,sectionid, subid);
            dataGridView1.DataSource = db.view_schedule(sectionid);
            MessageBox.Show("Schedule added sucessfully", "Message");
        }
    }
}
