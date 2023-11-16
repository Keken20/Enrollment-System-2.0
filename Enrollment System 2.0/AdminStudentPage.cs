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
            action.Name = "deletebtn";
            action.Text = "Remove";
            action.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(action);
        }
        public void LoadData()
        {
            dataGridView1.DataSource = db.enrolled_view();
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_enrolled_view(tbsearch.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "deletebtn")
                {
                    int studid = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    if (MessageBox.Show("Confirm?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.unenroll_student(studid);
                        LoadData();
                        MessageBox.Show("Student unerolled succesfully!", "Message");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records found", "Error");
            }
           
        }
    }

}

