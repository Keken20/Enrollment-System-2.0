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
            dtgrv.DataSource = db.enrollees_view();

            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.HeaderText = "Action";
            action.Name = "acceptbtn";
            action.Text = "Enroll";
            action.UseColumnTextForButtonValue = true;
            dtgrv.Columns.Add(action);
        }
        public  void DisplayData()
        {
            dtgrv.DataSource = db.enrollees_view();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgrv.Columns[e.ColumnIndex].Name == "acceptbtn")
                {
                    int id = int.Parse(dtgrv.CurrentRow.Cells[1].Value.ToString());
                    string name = (dtgrv.CurrentRow.Cells[2].Value.ToString());
                    int count = db.get_stud(id).Count(); 
                        EnrollStudent d = new EnrollStudent(this);
                        d.studentid = id;
                        d.ShowDialog();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No Records on selected cell.", "Message");
            }
        }
    }
}
