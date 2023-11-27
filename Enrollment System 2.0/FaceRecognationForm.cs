using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Enrollment_System_2._0
{
    public partial class FaceRecognationForm : Form
    {
        public FaceRecognationForm()
        {
            InitializeComponent();
        }
        EnrollmentDataContext db = new EnrollmentDataContext();
        FaceRec fc = new FaceRec();
        public string user { get; set; }
        string fr;
        string fname;
        string lname;
        string full;
        private void FaceRecognationForm_Load(object sender, EventArgs e)
        {
            fc.openCamera(pbOpenCamera, pbOpenCamera);
            checkFaceRecog();
        }

        private void checkFaceRecog()
        {
            var result = db.admin_info(user);
            foreach(var item in result)
            {
                fr = item.admin_facename;
                fname = item.admin_fname;
                lname = item.admin_lname;
                full = fname + " " + lname;

            }

            if(fr == null)
            {
                MessageBox.Show("Insert your image first!!", "Message");              
                btnCaptureImage.Visible = true;
                btnLogin.Visible = false;
            }
            else
            {
                fc.getPersonName(Fullname);
                fc.isTrained = true;
                full = fname + " " + lname;             
            }
        }

        private void btnCaptureImage_Click(object sender, EventArgs e)
        {
            string imagename = fname + " " + lname;
            db.update_facerecog(imagename);
            fc.Save_IMAGE(imagename);
            fc.isTrained = true;
            MessageBox.Show("Succesfully Save", "Message");
            btnLogin.Visible = true;
        }
        private void ShowAdminDashboard()
        {
            AdminDashboad f2 = new AdminDashboad();
            f2.Show();
            Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Fullname.Text == full)
            {
                ShowAdminDashboard();
            }
            else
            {
                MessageBox.Show("Error!", "Message");

            }
           
        }
    }
}
