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
    public partial class StudentCreateForm : Form
    {
        String gender;

        public StudentCreateForm()
        {
            InitializeComponent();
        }
        private void btnStdCreate_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
            if (rdoStdCrtMale.Checked == true)
            {
                this.gender = "Male";
            }
            else if (rdoStdCrtFemale.Checked == true)
            {
                this.gender = "Female";
            }
            DateTime dob = DateTime.Parse(dtpStdcrtDoB.Text);
            DateTime adDate = DateTime.Parse(dtpStdCrtAddDate.Text);
            sql = "INSERT INTO[students](addmission_no,[first_name],last_name,[full_name],gender,[date_of_birth],stu_nic_no,[tp_No],grade_id,[medium],date_of_addmission,[resident_address])VALUES('" + txtStdcrtAddmisNo.Text + "','" + txtStdcrtfname.Text + "','" + txtStdcrtLname.Text + "','" + txtStdcrtfullName.Text + "','" + this.gender + "','" + dob + "','" + txtStdcrtNic.Text + "','" + txtStdcrtphoneNo.Text + "','" + txtStdCrtGrdId.Text + "','" + cmbStdCrtMedium.Text + "','" + adDate + "','" + txtStdcrtaddress.Text + "')";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Student: " + txtStdCrtGrdId.Text + " added Successfully!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnStdcrtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
