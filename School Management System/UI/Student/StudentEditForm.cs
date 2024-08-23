using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System.UI.Student
{
    public partial class StudentEditForm : Form
    {
        String fname, lname, addNo, fullName, gend, dob, nic, phone, gradeId,medium, addDate, address,id;
        String gender;
        public StudentEditForm(String fname, String lname, String addNo, String fullName, String gend, String dob, String nic, String phone, String gradeId,String medium, String addDate, String address, String id)
        {
            this.fname = fname;
            this.lname = lname;
            this.addNo = addNo;
            this.fullName = fullName;
            this.gend = gend;
            this.dob = dob;
            this.nic = nic;
            this.phone = phone;
            this.gradeId = gradeId;
            this.medium = medium;
            this.addDate = addDate;
            this.address = address;
            this.id = id;
            InitializeComponent();
        }

        private void btnStdEdit_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtStdEdtAddmisNo.Text)) {
                MessageBox.Show("Enter your Addmission Number!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtStdEdtAddmisNo.Focus();
                return; 
            }else if (String.IsNullOrEmpty(txtStdEdtfname.Text))
            {
                MessageBox.Show("Enter your First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtfname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtLname.Text))
            {
                MessageBox.Show("Enter your Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtLname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtfullName.Text))
            {
                MessageBox.Show("Enter your Full Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtfullName.Focus();
                return;
            }
            else if(rdoStdEdtMale.Checked==false && rdoStdEdtFemale.Checked == false)
            {
                MessageBox.Show("Please select your gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdoStdEdtMale.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtNic.Text))
            {
                MessageBox.Show("Enter your Nic number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtNic.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtphoneNo.Text))
            {
                MessageBox.Show("Enter your Phone Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtphoneNo.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtGrdId.Text))
            {
                MessageBox.Show("Enter your Grade Id!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtGrdId.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(cmbStdEdtMedium.Text))
            {
                MessageBox.Show("Select your medium!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStdEdtMedium.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtaddress.Text))
            {
                MessageBox.Show("Enter your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtaddress.Focus();
                return;
            }
            Int32 num = 0;
            Boolean isNumber=Int32.TryParse(txtStdEdtGrdId.Text, out num);
            if (!isNumber)
            {
                MessageBox.Show("Enter your gradeId as number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtGrdId.Focus();
                return;
            }
            Int32 num1 = 0;
            Boolean isNumber1=Int32.TryParse(txtStdEdtphoneNo.Text, out num1);
            if (!isNumber1)
            {
                MessageBox.Show("Enter your Phone number as number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtphoneNo.Focus();
                return;
            }
            if (txtStdEdtphoneNo.Text.Length!=10)
            {
                MessageBox.Show("phone number should be 10 value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtphoneNo.Focus();
                return;
            }
            String adNo, fname, lname, fullName, nic, phone, gradeId, medium, address;

            adNo = txtStdEdtAddmisNo.Text;
            fname = txtStdEdtfname.Text;
            lname = txtStdEdtLname.Text;
            fullName = txtStdEdtfullName.Text;
            if (rdoStdEdtMale.Checked == true)
            {
                this.gender = "Male";
            }
            else if (rdoStdEdtFemale.Checked == true)
            {
                this.gender = "Female";
            }
            DateTime dob = DateTime.Parse(dtpStdEdtDoB.Text);
            DateTime adDate = DateTime.Parse(dtpStdEdtAddDate.Text);
            nic = txtStdEdtNic.Text;
            phone = txtStdEdtphoneNo.Text;
            gradeId = txtStdEdtGrdId.Text;
            medium = cmbStdEdtMedium.Text;
            address = txtStdEdtaddress.Text;
            int id = Convert.ToInt32(this.id);
           int count= DAL.StudentDal.countStudentUpdate(adNo,nic, phone, id);
            if (count != 0)
            {
                MessageBox.Show("This student details already exist!");
                return;
            }
            else {
                DAL.StudentDal.update(adNo, fname, lname, fullName, this.gender, dob, nic, phone, gradeId, medium, adDate, address, this.id);
                MessageBox.Show("Student Id : " + this.id + " details Updated successfully");
                this.Close();
            }
                
            
            
        }
        private void btnStdEdtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StudentEditForm_Load(object sender, EventArgs e)
        {
            txtStdEdtAddmisNo.Text = this.addNo;
            txtStdEdtfname.Text = this.fname;
            txtStdEdtLname.Text = this.lname;
            txtStdEdtfullName.Text = this.fullName;
            txtStdEdtNic.Text = this.nic;
            txtStdEdtphoneNo.Text = this.phone;
            txtStdEdtaddress.Text = this.address;
            cmbStdEdtMedium.Text = this.medium;
            txtStdEdtGrdId.Text=this.gradeId;
            dtpStdEdtDoB.Text = this.dob;
            dtpStdEdtAddDate.Text = this.addDate;
            if (this.gend == "Male")
            {
                rdoStdEdtMale.Checked = true;
            }
            else if (this.gend == "Female")
            {
                rdoStdEdtFemale.Checked = true;
            }
        }
    }
}
