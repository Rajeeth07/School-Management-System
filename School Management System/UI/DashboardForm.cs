using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UI.Login.LoginForm loginForm = new UI.Login.LoginForm();
            loginForm.Show();
        }

        private void btnStdDashStudent_Click(object sender, EventArgs e)
        {
            UI.Student.StudentMasterForm studentMasterForm = new UI.Student.StudentMasterForm();
            studentMasterForm.Show();
        }

        private void btnStdDashSubject_Click(object sender, EventArgs e)
        {
            UI.Subject.SubjectMasterForm subjectMasterForm = new UI.Subject.SubjectMasterForm();
                subjectMasterForm.Show();
        }

        private void btnStdDashGrade_Click(object sender, EventArgs e)
        {
            UI.Grade.GradeMasterForm gradeMasterForm=new UI.Grade.GradeMasterForm();    
            gradeMasterForm.Show();
        }

      
    }
}
