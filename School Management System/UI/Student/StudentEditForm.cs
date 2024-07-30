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
            string connetionString = null;
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
