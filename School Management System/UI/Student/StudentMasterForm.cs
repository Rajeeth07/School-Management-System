using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace School_Management_System.UI.Student
{
    public partial class StudentMasterForm : Form
    {   
        DataTable dt=new DataTable();
        DataView dv;
        String fname, lname, addNo, fullName, gend, dob, nic, phone, gradeId, medium, addDate, address,id;
        String name;


        public StudentMasterForm()
        {
            InitializeComponent();
        }
        #region User Define Functions
        private void formLoad()
        {   
            dt = DAL.StudentDal.getAll();
            dv=dt.DefaultView;
            dgvStd.DataSource = dv;
        }
        private void selectedRowValues()
        {
            this.fname = dgvStd.SelectedRows[0].Cells["first_name"].Value.ToString();
            this.fname = dgvStd.SelectedRows[0].Cells["first_name"].Value.ToString();
            this.lname = dgvStd.SelectedRows[0].Cells["last_name"].Value.ToString();
            this.addNo = dgvStd.SelectedRows[0].Cells["admission_no"].Value.ToString();
            this.fullName = dgvStd.SelectedRows[0].Cells["full_name"].Value.ToString();
            this.gend = dgvStd.SelectedRows[0].Cells["gender"].Value.ToString();
            this.dob = dgvStd.SelectedRows[0].Cells["date_of_birth"].Value.ToString();
            this.nic = dgvStd.SelectedRows[0].Cells["stu_nic_no"].Value.ToString();
            this.phone = dgvStd.SelectedRows[0].Cells["tp_No"].Value.ToString();
            this.gradeId = dgvStd.SelectedRows[0].Cells["grade_id"].Value.ToString();
            this.medium = dgvStd.SelectedRows[0].Cells["medium"].Value.ToString();
            this.addDate = dgvStd.SelectedRows[0].Cells["date_of_addmission"].Value.ToString();
            this.address = dgvStd.SelectedRows[0].Cells["resident_address"].Value.ToString();
            this.id = dgvStd.SelectedRows[0].Cells["id"].Value.ToString();
        }
        #endregion
        private void btnStdAdd_Click(object sender, EventArgs e)
        {
            UI.Student.StudentCreateForm studentCreateForm = new UI.Student.StudentCreateForm();    
            studentCreateForm.ShowDialog();
        }
        private void btnStdEdit_Click(object sender, EventArgs e)
        {
            UI.Student.StudentEditForm studentEditForm = new UI.Student.StudentEditForm(this.fname, this.lname, this.addNo, this.fullName, this.gend, this.dob, this.nic, this.phone, this.gradeId, this.medium, this.addDate, this.address, this.id);
            studentEditForm.ShowDialog();
        }
        private void btnStdDelete_Click(object sender, EventArgs e)
        {
            //Delete function
            DialogResult dr = MessageBox.Show("Do you want delete Admission No : " + this.addNo + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            int id=Convert.ToInt32(this.id);
            DAL.StudentDal.delete(id);
            MessageBox.Show("Student Id : "+id+" details deleted successfully");


        }
        private void StudentMasterForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }
        private void btnStdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StudentMasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr=MessageBox.Show("Do you want exit?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No) { 
                e.Cancel = true;
            }
        }
        private void txtStuSearch_TextChanged(object sender, EventArgs e)
        {
            dv = new DataView(dt, "addmission_no like '%" + txtStuSearch.Text+"%' or first_name like '%"+txtStuSearch.Text+"%' or last_name like '%"+txtStuSearch.Text+"%' or full_name like '%"+txtStuSearch.Text+"%' or gender like '%"+txtStuSearch.Text+"%' or stu_nic_no like '%"+txtStuSearch.Text+"%' or tp_No like '%"+txtStuSearch.Text+"%' or medium like '%"+txtStuSearch.Text+"%' or resident_address like '%"+txtStuSearch.Text+"%'", "first_name", DataViewRowState.CurrentRows);
            dgvStd.DataSource = dv;
        }
        private void btnStdRefresh_Click(object sender, EventArgs e)
        {
            formLoad();
            txtStuSearch.Text=null;
        }
    }
}
