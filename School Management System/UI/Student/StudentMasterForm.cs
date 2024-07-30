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

namespace School_Management_System.UI.Student
{
    public partial class StudentMasterForm : Form
    {   
        DataTable dt=new DataTable();
        DataView dv;
        String fname,lname,addNo,fullName,gend,dob,nic,phone,gradeId,medium,addDate,address,id;


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

            this.fname = dgvStd.SelectedRows[0].Cells["first_name"].Value.ToString();
            this.fname = dgvStd.SelectedRows[0].Cells["first_name"].Value.ToString();
            this.lname = dgvStd.SelectedRows[0].Cells["last_name"].Value.ToString();
            this.addNo = dgvStd.SelectedRows[0].Cells["addmission_no"].Value.ToString();
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
            UI.Student.StudentEditForm studentEditForm = new UI.Student.StudentEditForm(this.fname, this.lname, this.addNo, this.fullName, this.gend, this.dob, this.nic, this.phone, this.gradeId, this.medium, this.addDate, this.address,this.id);  
            studentEditForm.ShowDialog();
        }

        private void btnStdDelete_Click(object sender, EventArgs e)
        {
            
            this.id = dgvStd.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("Do you want to delete Id: " + this.id + "?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            //Delete function
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
            
            sql = "delete from students where id='" + this.id + "'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Student Id " + this.id + " details deleted successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        private void StudentMasterForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void formLoad()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
            sql = "select * from students";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(dataReader);
                dv = dt.DefaultView;
                dgvStd.DataSource = dv;
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
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
            dv = new DataView(dt, "addmission_no like '%"+txtStuSearch.Text+"%' or first_name like '%"+txtStuSearch.Text+"%' or last_name like '%"+txtStuSearch.Text+"%' or full_name like '%"+txtStuSearch.Text+"%' or gender like '%"+txtStuSearch.Text+"%' or stu_nic_no like '%"+txtStuSearch.Text+"%' or tp_No like '%"+txtStuSearch.Text+"%' or medium like '%"+txtStuSearch.Text+"%' or resident_address like '%"+txtStuSearch.Text+"%'", "first_name", DataViewRowState.CurrentRows);
            dgvStd.DataSource = dv;
        }

        private void btnStdRefresh_Click(object sender, EventArgs e)
        {
            formLoad();
            txtStuSearch.Text=null;
        }
    }
}
