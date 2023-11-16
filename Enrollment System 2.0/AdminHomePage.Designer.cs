
namespace Enrollment_System_2._0
{
    partial class AdminHomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total_instructor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.total_enrolled = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.total_enrollees = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(365, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOME PAGE";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.total_instructor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(656, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 615);
            this.panel1.TabIndex = 8;
            // 
            // total_instructor
            // 
            this.total_instructor.AutoSize = true;
            this.total_instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_instructor.ForeColor = System.Drawing.Color.SteelBlue;
            this.total_instructor.Location = new System.Drawing.Point(127, 141);
            this.total_instructor.Name = "total_instructor";
            this.total_instructor.Size = new System.Drawing.Size(92, 55);
            this.total_instructor.TabIndex = 9;
            this.total_instructor.Text = "TO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.total_enrolled);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 615);
            this.panel2.TabIndex = 9;
            // 
            // total_enrolled
            // 
            this.total_enrolled.AutoSize = true;
            this.total_enrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_enrolled.ForeColor = System.Drawing.Color.SteelBlue;
            this.total_enrolled.Location = new System.Drawing.Point(112, 141);
            this.total_enrolled.Name = "total_enrolled";
            this.total_enrolled.Size = new System.Drawing.Size(92, 55);
            this.total_enrolled.TabIndex = 10;
            this.total_enrolled.Text = "TO";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.total_enrollees);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(328, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 615);
            this.panel3.TabIndex = 9;
            // 
            // total_enrollees
            // 
            this.total_enrollees.AutoSize = true;
            this.total_enrollees.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_enrollees.ForeColor = System.Drawing.Color.SteelBlue;
            this.total_enrollees.Location = new System.Drawing.Point(123, 141);
            this.total_enrollees.Name = "total_enrollees";
            this.total_enrollees.Size = new System.Drawing.Size(92, 55);
            this.total_enrollees.TabIndex = 11;
            this.total_enrollees.Text = "TO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 87);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(984, 615);
            this.panel5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Image = global::Enrollment_System_2._0.Properties.Resources.icons8_student_registration_502;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(111, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 104);
            this.label5.TabIndex = 11;
            this.label5.Text = "\r\n\r\n\r\nEnrollees ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Image = global::Enrollment_System_2._0.Properties.Resources.icons8_online_registration_50;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(79, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 104);
            this.label3.TabIndex = 8;
            this.label3.Text = "\r\n\r\n\r\nEnrolled Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Image = global::Enrollment_System_2._0.Properties.Resources.icons8_teacher_501;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(108, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 104);
            this.label4.TabIndex = 12;
            this.label4.Text = "\r\n\r\n\r\nInstructor ";
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 702);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label total_instructor;
        private System.Windows.Forms.Label total_enrolled;
        private System.Windows.Forms.Label total_enrollees;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}