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
        int id;

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

            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.HeaderText = "Delete";
            action.Name = "deletebtn";
            action.Text = "Remove";
            action.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(action);
            ClearData();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string insfname = instructorfname.Text;
            string inslname = instructorlname.Text;
            int subid = Convert.ToInt32(comboBox1.SelectedValue);
            if (instructorfname.Text == "" || instructorlname.Text == "" || comboBox1.SelectedValue == null)
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
            comboBox1.SelectedValue = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (instructorfname.Text == "" || instructorlname.Text == "" || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Fill all informations", "Error");
            }
            else if (id != int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
            {
                MessageBox.Show("Cannot Update, Data not in the Database", "Error");
            }
            else
            {
                db.update_instructor(id, instructorfname.Text, instructorlname.Text, Convert.ToInt32(comboBox1.SelectedValue));
                dataGridView1.DataSource = db.view_instructor();
                MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK);
                ClearData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index == dataGridView1.Rows.Count - 1)
                {
                    MessageBox.Show("No records found!", "Message");
                }
                else
                {
                    id = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    instructorfname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    instructorlname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "deletebtn")
                    {
                        if (MessageBox.Show("Confirm?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.delete_instructor(id);
                            dataGridView1.DataSource = db.view_instructor();
                            MessageBox.Show("Instructor deleted sucessfully", "Message");
                            ClearData();
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
