
namespace Enrollment_System_2._0
{
    partial class StudentEnrollmentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.ComboBox();
            this.sem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.yearlevel = new System.Windows.Forms.ComboBox();
            this.acadyear = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.middlename = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(170, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "Academic Year";
            // 
            // course
            // 
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "BIT-CT"});
            this.course.Location = new System.Drawing.Point(406, 256);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(207, 21);
            this.course.TabIndex = 70;
            // 
            // sem
            // 
            this.sem.FormattingEnabled = true;
            this.sem.Items.AddRange(new object[] {
            "First",
            "Second"});
            this.sem.Location = new System.Drawing.Point(406, 319);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(207, 21);
            this.sem.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(401, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 68;
            this.label8.Text = "Semester";
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.BackColor = System.Drawing.Color.SteelBlue;
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(351, 385);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(73, 37);
            this.submit.TabIndex = 67;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // yearlevel
            // 
            this.yearlevel.FormattingEnabled = true;
            this.yearlevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.yearlevel.Location = new System.Drawing.Point(174, 256);
            this.yearlevel.Name = "yearlevel";
            this.yearlevel.Size = new System.Drawing.Size(207, 21);
            this.yearlevel.TabIndex = 66;
            // 
            // acadyear
            // 
            this.acadyear.FormattingEnabled = true;
            this.acadyear.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.acadyear.Location = new System.Drawing.Point(174, 319);
            this.acadyear.Name = "acadyear";
            this.acadyear.Size = new System.Drawing.Size(207, 21);
            this.acadyear.TabIndex = 65;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Old",
            "New",
            "Transferee"});
            this.status.Location = new System.Drawing.Point(406, 192);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(207, 21);
            this.status.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(401, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(401, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(170, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Year Level";
            // 
            // middlename
            // 
            this.middlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlename.Location = new System.Drawing.Point(174, 190);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(207, 23);
            this.middlename.TabIndex = 60;
            // 
            // firstname
            // 
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(406, 121);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(207, 23);
            this.firstname.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(170, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(401, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "First Name:";
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(174, 121);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(207, 23);
            this.lastname.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(169, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Last Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 87);
            this.panel4.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(798, 85);
            this.label10.TabIndex = 4;
            this.label10.Text = "ENROLLMENT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentEnrollmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.course);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.yearlevel);
            this.Controls.Add(this.acadyear);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Name = "StudentEnrollmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentEnrollmentPage";
            this.Load += new System.EventHandler(this.StudentEnrollmentPage_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.ComboBox sem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox yearlevel;
        private System.Windows.Forms.ComboBox acadyear;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
    }
}