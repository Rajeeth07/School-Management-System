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
            

            if (String.IsNullOrEmpty(txtStdcrtAddmisNo.Text))
            {
                MessageBox.Show("Enter your Addmission Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtAddmisNo.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtfname.Text))
            {
                MessageBox.Show("Enter your First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtfname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtLname.Text))
            {
                MessageBox.Show("Enter your Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtLname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtfullName.Text))
            {
                MessageBox.Show("Enter your Full Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtfullName.Focus();
                return;
            }
            else if (rdoStdCrtMale.Checked == false && rdoStdCrtFemale.Checked == false)
            {
                MessageBox.Show("Please select your gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdoStdCrtMale.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtNic.Text))
            {
                MessageBox.Show("Enter your Nic number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtNic.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtphoneNo.Text))
            {
                MessageBox.Show("Enter your Phone Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdCrtGrdId.Text))
            {
                MessageBox.Show("Enter your Grade Id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdCrtGrdId.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(cmbStdCrtMedium.Text))
            {
                MessageBox.Show("Select your medium!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStdCrtMedium.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdcrtaddress.Text))
            {
                MessageBox.Show("Enter your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtaddress.Focus();
                return;
            }
            Int32 num = 0;
            Boolean isNumber = Int32.TryParse(txtStdCrtGrdId.Text, out num);
            if (!isNumber)
            {
                MessageBox.Show("Enter your gradeId as number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdCrtGrdId.Focus();
                return;
            }
            Int32 num1 = 0;
            Boolean isNumber1 = Int32.TryParse(txtStdcrtphoneNo.Text, out num1);
            if (!isNumber1)
            {
                MessageBox.Show("Enter your Phone number as number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return;
            }
            if (txtStdcrtphoneNo.Text.Length != 10)
            {
                MessageBox.Show("phone number should be 10 value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdcrtphoneNo.Focus();
                return;
            }
            String adNo, fname, lname, fullName, nic, phone, gradeId, medium, address;

            adNo = txtStdcrtAddmisNo.Text;
            fname = txtStdcrtfname.Text;
            lname = txtStdcrtLname.Text;
            fullName = txtStdcrtfullName.Text;
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

            nic = txtStdcrtNic.Text;
            phone = txtStdcrtphoneNo.Text;
            gradeId = txtStdCrtGrdId.Text;
            medium = cmbStdCrtMedium.Text;
            address = txtStdcrtaddress.Text;
            
            int count=DAL.StudentDal.countStudentRow(adNo, nic, phone);
            if (count!=0)
            {
                MessageBox.Show("This student details already exist!");
                return;
            }
            else
            {
                DAL.StudentDal.insert(adNo, fname, lname, fullName, this.gender, dob, nic, phone, gradeId, medium, adDate, address);
                MessageBox.Show("New Student added successfully");
                this.Close();
            }
            
        }
        private void btnStdcrtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
