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
            if (String.IsNullOrEmpty(txtStdEdtAddmisNo.Text))
            {
                MessageBox.Show("Addmission Number field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtAddmisNo.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtfname.Text))
            {
                MessageBox.Show("First Name field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtfname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtLname.Text))
            {
                MessageBox.Show("Last Name field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtLname.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtfullName.Text))
            {
                MessageBox.Show("fullname field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtfullName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtNic.Text))
            {
                MessageBox.Show("Nic field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStdEdtDoB.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtphoneNo.Text))
            {
                MessageBox.Show("phone number can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtphoneNo.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtGrdId.Text))
            {
                MessageBox.Show("please enter your grade id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtGrdId.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(cmbStdEdtMedium.Text))
            {
                MessageBox.Show("please select a medium", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStdEdtMedium.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtStdEdtaddress.Text))
            {
                MessageBox.Show("please enter your address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtaddress.Focus();
                return;
            }
            if (rdoStdEdtMale.Checked == false && rdoStdEdtFemale.Checked == false)
            {
                MessageBox.Show("please select a gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labStuEdtGender.Focus();
                return;
            }
            int num;
            Boolean isNumber1 = Int32.TryParse(txtStdEdtGrdId.Text, out num);
            if (!isNumber1)
            {
                MessageBox.Show("grade Id shoud be a number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtGrdId.Focus();
                return;

            }

            Boolean isNumber2 = Int32.TryParse(txtStdEdtphoneNo.Text, out num);
            if (!isNumber2)
            {
                MessageBox.Show("phone number shoud be a number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtGrdId.Focus();
                return;

            }
            if (txtStdEdtphoneNo.Text.Length != 10)
            {
                MessageBox.Show("phone number shoud be 10 numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStdEdtphoneNo.Focus();
                return;
            }
            DAL.StudentDal.update(adNo, fname, lname, fullName, this.gender, dob, nic, phone, gradeId, medium, adDate, address,this.id);
            MessageBox.Show("Student Id : "+this.id+" details Updated successfully");
            this.Close();
            /*string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
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
            sql = "UPDATE [students] SET [addmission_no]='"+txtStdEdtAddmisNo.Text+"',[first_name]='"+txtStdEdtfname.Text+"',[last_name]='"+txtStdEdtLname.Text+"',[full_name]='"+txtStdEdtfullName.Text+"',[gender]='"+this.gender+"',[date_of_birth]='"+dob+"',[stu_nic_no]='"+txtStdEdtNic.Text+"',[tp_No]='"+txtStdEdtphoneNo.Text+"',[grade_id]='"+txtStdEdtGrdId.Text+"',[medium]='"+cmbStdEdtMedium.Text+"',[date_of_addmission]='"+adDate+"',[resident_address]='"+txtStdEdtaddress.Text+"' WHERE id='"+this.id+"'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Student : "+this.id+" Updated Successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
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
