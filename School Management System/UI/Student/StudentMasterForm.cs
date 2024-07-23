using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.Student
{
    public partial class StudentMasterForm : Form
    {
        public StudentMasterForm()
        {
            InitializeComponent();
        }

        private void btnStdAdd_Click(object sender, EventArgs e)
        {
            UI.Student.StudentCreateForm studentCreateForm = new UI.Student.StudentCreateForm();    
            studentCreateForm.ShowDialog();
        }

        private void btnStdEdit_Click(object sender, EventArgs e)
        {
            UI.Student.StudentEditForm studentEditForm = new UI.Student.StudentEditForm();  
            studentEditForm.ShowDialog();
        }
    }
}
