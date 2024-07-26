using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        String fname, lname, addNo, fullName, gend, dob, nic, phone, gradeId, addDate, address;
        public StudentCreateForm(String fname, String lname, String addNo, String fullName, String gend, String dob, String nic, String phone, String gradeId, String addDate, String address)
        {
            this.fname = fname;
            this.lname= lname;
            this.addNo= addNo;
            this.fullName= fullName;
            this.gend = gend;
            this.dob= dob;
            this.nic = nic;
            this.phone = phone;
            this.gradeId = gradeId;
            this.addDate = addDate;
            this.address = address;
            InitializeComponent();
        }

        private void StudentCreateForm_Load(object sender, EventArgs e)
        {
            txtStdcrtAddmisNo.Text=this.addNo;
            txtStdcrtfname.Text=this.fname;
            txtStdcrtLname.Text=this.lname;
            txtStdcrtfullName.Text=this.fullName;
            txtStdcrtNic.Text=this.nic;
            txtStdcrtphoneNo.Text=this.phone;
            txtStdcrtaddress.Text=this.address;
            cmbStdCrtGrdId.Text=this.gradeId;
            dtpStdcrtDoB.Text=this.dob;
            dtpStdCrtAddDate.Text=this.addDate;
            if (this.gend == "Male")
            {
                rdoStdCrtMale.Checked = true;
            }else if(this.gend == "Female")
            {
                rdoStdCrtFemale.Checked = true;
            }
        }
    }
}
