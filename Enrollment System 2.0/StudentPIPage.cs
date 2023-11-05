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
        public string username { get; set; }
        public StudentPIPage()
        {
            InitializeComponent();
        }

        private void StudentPIPage_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
        static int GetAge(DateTime birth)
        {


        }
        public void DisplayData()
        {

        }
    }
}
