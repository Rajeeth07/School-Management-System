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
                dt=new DataTable();
                dt.Load(dataReader);
                dv=dt.DefaultView;
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
    }
}
