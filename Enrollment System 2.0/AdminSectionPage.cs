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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var result = db.get_courseid(comboBox1.SelectedValue.ToString());
            foreach(var item in result)
            {
                courid = item.course_id;
            }
            db.add_section(comboBox1.SelectedValue.ToString(), txbyear.Text, txbname.Text, courid);
            MessageBox.Show("Section created sucessfully", "Message");
            dataGridView1.DataSource = db.view_section();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "view")
            {
                int secid = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                AdminSchedulePage g = new AdminSchedulePage();
                g.sectionid = secid;    
                g.ShowDialog();             
            }
        }
    }
}
