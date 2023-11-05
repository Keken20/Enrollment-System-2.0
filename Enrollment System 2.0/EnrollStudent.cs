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
        EnrollmentDataContext db = new EnrollmentDataContext();
        public int enrollmentid { get; set; }
        public EnrollStudent()
        {
            InitializeComponent();
        }

        private void EnrollStudent_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.view_section();
            comboBox1.DisplayMember = "section_name";
            comboBox1.ValueMember = "section_id";
        }
    }
}
