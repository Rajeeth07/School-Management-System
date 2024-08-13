using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.GradeSubject
{
    public partial class GradeSubjectForm : Form
    {

        Boolean is_addNew = false;
        DataTable dt = new DataTable();
        DataView dv;
        String id;
        public GradeSubjectForm()
        {
            InitializeComponent();
        }
        private void ButtonEnable(bool is_true)
        {
            is_addNew = is_true;
            btngrdsubAdd.Enabled = !is_true;
            btngrdsubDelete.Enabled = !is_true;
            btngrdsubEdit.Enabled = !is_true;
            btngrdsubExit.Enabled = !is_true;
            btngrdsubRefresh.Enabled = !is_true;

            btngrdsubSave.Enabled = is_true;
            btngrdsubCancel.Enabled = is_true;
        }
        private void btnGrdRefresh_Click(object sender, EventArgs e)
        {
            formLoad();
            cmbGrdSubgrd.SelectedIndex = -1;
            cmbGrdSubSub.SelectedIndex = -1;
        }

        private void formLoad() {
            DataTable dt = DAL.GradeSubject.getAll();
            dgvSubGrd.DataSource = dt;
            dgvSubGrd.Columns["id"].Visible = false;
            dgvSubGrd.Columns["grade_id"].Visible = false;
            dgvSubGrd.Columns["subject_id"].Visible = false;

            DataTable dtGrade = DAL.GradeDal.getAll();
            cmbGrdSubgrd.DataSource = dtGrade;
            cmbGrdSubgrd.DisplayMember = "grade_group";
            cmbGrdSubgrd.ValueMember = "id";

            DataTable dtSubject = DAL.SubjectDal.getAll();
            cmbGrdSubSub.DataSource = dtSubject;
            cmbGrdSubSub.DisplayMember = "subject_name";
            cmbGrdSubSub.ValueMember = "id";
        }

        private void GradeSubjectForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void btngrdsubAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            
        }     



        private void btngrdsubDelete_Click(object sender, EventArgs e)
        {

        }

        private void btngrdsubEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew = false;
        }

        private void btngrdsubSave_Click(object sender, EventArgs e)
        {
            String GrdId = cmbGrdSubgrd.SelectedValue.ToString();
            String SubId = cmbGrdSubSub.SelectedValue.ToString();
            
           
            if (is_addNew)
            {

                //insert
                Int32 count= DAL.GradeSubject.countAddValue(GrdId, SubId);
                
                if (count != 0)
                {
                    MessageBox.Show("This is already exist");
                }
                else
                {
                    DAL.GradeSubject.insert(GrdId, SubId);
                    MessageBox.Show("Grade Subject details added successfully!");
                }
                
            }
            else
            {
                //update
                
            }
            ButtonEnable(false);
        }

        private void btngrdsubCancel_Click(object sender, EventArgs e)
        {

        }

        private void btngrdsubExit_Click(object sender, EventArgs e)
        {

        }

        private void txtgrdsubSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSubGrd_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
