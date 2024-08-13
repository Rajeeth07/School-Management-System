using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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
            String adNo, fname, lname, fullName,nic, phone, gradeId, medium, address;
            
            adNo =txtStdcrtAddmisNo.Text;
            fname=txtStdcrtfname.Text;
            lname =txtStdcrtLname.Text;
            fullName =txtStdcrtfullName.Text;
            if (rdoStdCrtMale.Checked == true)
            {
                this.gender = "Male";
            } else if (rdoStdCrtFemale.Checked == true)
            {
               this.gender = "Female";
            }
            DateTime dob = DateTime.Parse(dtpStdcrtDoB.Text);
            DateTime adDate = DateTime.Parse(dtpStdCrtAddDate.Text);
            nic =txtStdcrtNic.Text;
            phone =txtStdcrtphoneNo.Text;
            gradeId =txtStdCrtGrdId.Text;
            medium =cmbStdCrtMedium.Text;
            address =txtStdcrtaddress.Text;
            if (String.IsNullOrEmpty(txtStdcrtAddmisNo.Text))
            {
                MessageBox.Show("Addmission Number field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtAddmisNo.Focus();
                return;
            }else if (String.IsNullOrEmpty(txtStdcrtfname.Text))
            {
                MessageBox.Show("First Name field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtfname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtLname.Text))
            {
                MessageBox.Show("Last Name field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtLname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtfullName.Text))
            {
                MessageBox.Show("fullname field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtfullName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtNic.Text))
            {
                MessageBox.Show("Nic field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStdcrtDoB.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtphoneNo.Text))
            {
                MessageBox.Show("phone number can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return;
            }
            
            else if (String.IsNullOrEmpty(cmbStdCrtMedium.Text))
            {
                MessageBox.Show("please select a medium", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStdCrtMedium.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtaddress.Text))
            {
                MessageBox.Show("please enter your address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtaddress.Focus();
                return;
            }
            if (rdoStdCrtMale.Checked == false && rdoStdCrtFemale.Checked == false)
            {
                MessageBox.Show("please select a gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labStuCrtGender.Focus();
                    return;
            }



            


            if (txtStdcrtphoneNo.Text.Length != 10)
            {
                MessageBox.Show("phone number shoud be 10 numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return;
            }
            DAL.StudentDal.insert(adNo,fname,lname,  fullName,  this.gender,  dob,  nic,  phone,  gradeId,  medium,  adDate,  address);
            MessageBox.Show("New Student added successfully");
            this.Close();
            
            /*
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
            }*/
        }

        private void btnStdcrtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
