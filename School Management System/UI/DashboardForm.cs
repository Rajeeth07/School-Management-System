using School_Management_System.UI.Student;
using School_Management_System.UI.Subject;
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

        

        private void btnStdDashGrade_Click(object sender, EventArgs e)
        {
            UI.Grade.GradeMasterForm gradeMasterForm=new UI.Grade.GradeMasterForm();    
            gradeMasterForm.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Student.StudentMasterForm studentMasterForm = new UI.Student.StudentMasterForm();
            studentMasterForm.MdiParent=this;
            studentMasterForm.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Subject.SubjectMasterForm subjectMasterForm = new UI.Subject.SubjectMasterForm();
            subjectMasterForm.MdiParent = this;
            subjectMasterForm.Show();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Grade.GradeMasterForm gradeMasterForm = new UI.Grade.GradeMasterForm();
            gradeMasterForm.MdiParent = this;
            gradeMasterForm.Show();

        }
    }
}
