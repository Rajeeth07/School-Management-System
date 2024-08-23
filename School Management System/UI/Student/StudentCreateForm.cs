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
        #region user define
        private bool ValidateStudentCreate()
        {
            if (String.IsNullOrEmpty(txtStdcrtAddmisNo.Text))
            {
                MessageBox.Show("Enter your Addmission Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtAddmisNo.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStdcrtfname.Text))
            {
                MessageBox.Show("Enter your First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtfname.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStdcrtLname.Text))
            {
                MessageBox.Show("Enter your Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtLname.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStdcrtfullName.Text))
            {
                MessageBox.Show("Enter your Full Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtfullName.Focus();
                return false;
            }
            else if (rdoStdCrtMale.Checked == false && rdoStdCrtFemale.Checked == false)
            {
                MessageBox.Show("Please select your gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdoStdCrtMale.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStdcrtNic.Text))
            {
                MessageBox.Show("Enter your Nic number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtNic.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStdcrtphoneNo.Text))
            {
                MessageBox.Show("Enter your Phone Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStdCrtGrdId.Text))
            {
                MessageBox.Show("Enter your Grade Id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdCrtGrdId.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(cmbStdCrtMedium.Text))
            {
                MessageBox.Show("Select your medium!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStdCrtMedium.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStdcrtaddress.Text))
            {
                MessageBox.Show("Enter your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtaddress.Focus();
                return false;
            }
            Int32 num = 0;
            Boolean isNumber = Int32.TryParse(txtStdCrtGrdId.Text, out num);
            if (!isNumber)
            {
                MessageBox.Show("Enter your gradeId as number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdCrtGrdId.Focus();
                return false;
            }
            Int32 num1 = 0;
            Boolean isNumber1 = Int32.TryParse(txtStdcrtphoneNo.Text, out num1);
            if (!isNumber1)
            {
                MessageBox.Show("Enter your Phone number as number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return false;
            }
            if (txtStdcrtphoneNo.Text.Length != 10)
            {
                MessageBox.Show("phone number should be 10 value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return false;
            }
            else {  
                return true;
            }
        }
        #endregion
        private void btnStdCreate_Click(object sender, EventArgs e)
        {
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
            if (ValidateStudentCreate()) 
            { 
                int count = DAL.StudentDal.countStudentRow(txtStdcrtAddmisNo.Text.Trim(), txtStdcrtNic.Text.Trim(), txtStdcrtphoneNo.Text.Trim());
                if (count != 0)
                {
                    MessageBox.Show("This student details already exist!");
                    return;
                }
                else
                {
                    DAL.StudentDal.insert(txtStdcrtAddmisNo.Text.Trim(), txtStdcrtfname.Text.Trim(), txtStdcrtLname.Text.Trim(), txtStdcrtfullName.Text.Trim(), this.gender, dob, txtStdcrtNic.Text.Trim(), txtStdcrtphoneNo.Text.Trim(), txtStdCrtGrdId.Text.Trim(), cmbStdCrtMedium.Text.Trim(), adDate, txtStdcrtaddress.Text.Trim());
                    MessageBox.Show("New Student added successfully");
                    this.Close();
                }
            }
        }
        private void btnStdcrtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
