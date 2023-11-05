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
    public partial class AdminHomePage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            total_enrollees.Text = db.enrollees_view().Count().ToString();
            total_enrolled.Text = db.enrolled_view().Count().ToString();
            total_instructor.Text = db.view_instructor().Count().ToString();
        }
    }
}
