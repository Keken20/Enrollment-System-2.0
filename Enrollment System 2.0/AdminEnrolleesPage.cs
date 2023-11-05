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
    public partial class AdminEnrolleesPage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        public AdminEnrolleesPage()
        {
            InitializeComponent();
        }

        private void AdminEnrolleesPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.enrollees_view();

            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.HeaderText = "Action";
            action.Name = "acceptbtn";
            action.Text = "Enroll";
            action.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(action);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "acceptbtn")
            {
                EnrollStudent d = new EnrollStudent();
                int id = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                d.enrollmentid = id;
                d.ShowDialog();
                //if (MessageBox.Show("Confirm?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //   
                //    db.accept_enrollment(id);
                //    dataGridView1.DataSource = db.enrollees_view();
                //}
            }
        }
    }
}
