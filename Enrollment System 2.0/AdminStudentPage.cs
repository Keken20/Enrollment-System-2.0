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
    public partial class AdminStudentPage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminStudentPage()
        {
            InitializeComponent();
        }

        private void AdminStudentPage_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.HeaderText = "Delete";
            action.Name = "deletetbtn";
            action.Text = "Remove";
            action.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(action);
        }
        public void LoadData()
        {
            dataGridView1.DataSource = db.enrolled_view();
        }

    }

}

