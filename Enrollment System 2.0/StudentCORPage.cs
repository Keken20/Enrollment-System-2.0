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
    public partial class StudentCORPage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public string username { get; set; }
        public int id;
        public StudentCORPage()
        {
            InitializeComponent();
        }

        private void StudentCORPage_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        public void DisplayData()
        {
            var result = db.get_id(username).ToList();
            foreach (var item in result)
            {
                id = item.stud_id;
            }
            var res = db.get_enrolled_info(id);
            foreach(var item in res)
            {
                dataGridView1.DataSource = db.view_student_cor(item.section_id);
            }
        }
    }
}
