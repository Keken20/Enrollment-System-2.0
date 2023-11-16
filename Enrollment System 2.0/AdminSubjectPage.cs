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
    public partial class AdminSubjectPage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        int id;

        public AdminSubjectPage()
        {
            InitializeComponent();
        }

        private void AdminSubjectPage_Load(object sender, EventArgs e)
        {
            var course = db.get_course().ToList();
            comboBox1.DataSource = course;
            comboBox1.DisplayMember = "course_name";
            comboBox1.ValueMember = "course_id";
            dataGridView1.DataSource = db.view_subject();

            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Action";
            remove.Name = "remove";
            remove.Text = "Remove";
            remove.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(remove);
            ClearData();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string subjectcode = subcode.Text.ToString();
            string subjectname = subname.Text.ToString();
            string subunit = subunits.Text.ToString();
            int sublevel = Convert.ToInt32(subyear.SelectedItem);
            int courseid = Convert.ToInt32(comboBox1.SelectedValue);


            if (subcode.Text == "" || subname.Text == "" || subunits.Text == "" || subunits.Text == "" || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Fill all informations", "Error");
            }
            else
            {
                MessageBox.Show("Subject added successfully", "Message");
                db.add_subject(subjectcode, subjectname, Convert.ToInt32(subunit), sublevel, courseid);
                dataGridView1.DataSource = db.view_subject();
                ClearData();
            }
        }
        private void ClearData()
        {
            subcode.Text = "";
            subname.Text = "";
            subunits.Text = "";
            subyear.Text = "";
            comboBox1.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (subcode.Text == "" || subname.Text == "" || subunits.Text == "" || subunits.Text == "" || comboBox1.SelectedValue == null )
            {
                MessageBox.Show("Fill all informations", "Error");
            }
            else if (id != int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
            {
                MessageBox.Show("Cannot Update, Data not in the Database", "Error");
            }
            else
            {
                db.update_subject(id, subcode.Text, subname.Text, Convert.ToInt32(subunits.Text), Convert.ToInt32(subyear.SelectedItem), Convert.ToInt32(comboBox1.SelectedValue));
                dataGridView1.DataSource = db.view_subject();
                MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK);
                ClearData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                subcode.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                subname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                subunits.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                subyear.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "remove")
                {
                    if (MessageBox.Show("Confirm?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.delete_subject(id);
                        dataGridView1.DataSource = db.view_subject();
                        MessageBox.Show("Subject deleted sucessfully", "Message");
                        ClearData();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records found!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
