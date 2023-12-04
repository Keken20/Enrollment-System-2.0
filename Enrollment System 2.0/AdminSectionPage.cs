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
    public partial class AdminSectionPage : Form
    {
        int courid;
        EnrollmentDataContext db = new EnrollmentDataContext();
        int id;
        int secid;

        public AdminSectionPage()
        {
            InitializeComponent();
        }

        private void AdminSectionPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.view_section();
            comboBox1.DataSource = db.get_course();
            comboBox1.DisplayMember = "course_name";
            comboBox1.ValueMember = "course_name";

            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.HeaderText = "Action";
            action.Name = "view";
            action.Text = "View Subject";
            action.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(action);
            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Action";
            remove.Name = "remove";
            remove.Text = "Remove";
            remove.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(remove);
            ClearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || txbyear.Text == " " || txbname.Text == "" )
            {
                MessageBox.Show("Input all information first!", "Message");
            }
            else if(db.check_section(comboBox1.SelectedValue.ToString(), int.Parse(txbyear.Text),txbname.Text).Count() != 0) 
            {
                MessageBox.Show("Section is already inserted!", "Message");
            }
            else
            {
                var result = db.get_courseid(comboBox1.SelectedValue.ToString());
                foreach (var item in result)
                {
                    courid = item.course_id;
                }
                db.add_section(comboBox1.SelectedValue.ToString(), txbyear.Text, txbname.Text, courid);
                MessageBox.Show("Section created sucessfully", "Message");
                dataGridView1.DataSource = db.view_section();
                ClearData();
            }
        }

        private void ClearData()
        {
            comboBox1.SelectedValue = " ";
            txbname.Text = " ";
            txbyear.Text = " ";

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || txbyear.Text == " " || txbname.Text == "")
            {
                MessageBox.Show("Input all information first!", "Message");
            }
            else
            {
                db.update_section(id, comboBox1.SelectedValue.ToString(), txbyear.Text, txbname.Text);
                dataGridView1.DataSource = db.view_section();
                MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK);
                ClearData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txbyear.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txbname.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "view")
                {
                    secid = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    AdminSchedulePage g = new AdminSchedulePage();
                    g.sectionid = secid;
                    g.ShowDialog();
                    ClearData();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "remove")
                {
                    if (MessageBox.Show("Confirm?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.delete_section_student(id);
                        db.delete_section(id);
                        db.delete_enrolled(id);
                        db.delete_sched(id);                      
                        dataGridView1.DataSource = db.view_section();
                        MessageBox.Show("Section deleted sucessfully", "Message");
                        ClearData();
                    }
                    ClearData();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
