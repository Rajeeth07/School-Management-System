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
