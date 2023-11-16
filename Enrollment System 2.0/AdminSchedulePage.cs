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
    public partial class AdminSchedulePage : Form
    {
        EnrollmentDataContext db = new EnrollmentDataContext();
        string sub;
        public int sectionid { get; set; }
        int schedid;
        public AdminSchedulePage()
        {
            InitializeComponent();
        }

        private void AdminSchedulePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.view_schedule(sectionid);
            var section = db.get_section_info(sectionid);
            foreach(var item in section)
            {
                txtsection.Text = item.section_course+ " " + item.section_yearlevel + "-" + item.section_name;
            }
            var subject = db.get_subject().ToList();
            this.subject.DataSource = subject;
            this.subject.DisplayMember = "subject_name";
            this.subject.ValueMember = "subject_id";

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
            if(txtsection.Text == " " || txbtime.Text == " " || txbday.Text == " " || subject.SelectedValue == null || txbroom.Text == " ")
            {
                MessageBox.Show("Fill all informations", "Message");
            }
            else
            {
                int subid = Convert.ToInt32(subject.SelectedValue);
                var result = db.get_sub_info(subid);
                foreach (var item in result)
                {
                    sub = item.subject_name;
                }
                db.add_schedule(txbsection.Text, sub, txbtime.Text, txbday.Text, txbday.Text, sectionid, subid);
                dataGridView1.DataSource = db.view_schedule(sectionid);
                MessageBox.Show("Schedule added sucessfully", "Message");
            }        
        }
        private void ClearData()
        {
            subject.SelectedValue = " ";
            txbsection.Text = " ";
            txbtime.Text = " ";
            txbday.Text = " ";
            txbroom.Text = " ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == dataGridView1.Rows.Count - 1)
            {
                MessageBox.Show("No records found!", "Message");
            }
            else
            {
                schedid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txbsection.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                subject.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txbtime.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txbday.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txbroom.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dataGridView1.Update();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "remove")
                {
                    if (MessageBox.Show("Confirm?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show(" ", "Message");
                    }
                }
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            schedid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int subid = Convert.ToInt32(subject.SelectedValue);
            var result = db.get_sub_info(subid);
            foreach (var item in result)
            {
                sub = item.subject_name;
            }
            db.update_schedtbl(schedid, txbsection.Text, sub, txbtime.Text, txbday.Text, txbroom.Text);
            dataGridView1.DataSource = db.view_schedule(sectionid);
            dataGridView1.Update();
            MessageBox.Show("Updated successfully! ", "Message");
        }
    }
}
