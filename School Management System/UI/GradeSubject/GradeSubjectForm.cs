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
        #region user define functions
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
        private void formLoad() {
            DataTable dt = DAL.GradeSubject.getAll();
            dgvSubGrd.DataSource = dt;
            dgvSubGrd.Columns["id"].Visible = false;
            dgvSubGrd.Columns["grade_id"].Visible = false;
            dgvSubGrd.Columns["subject_id"].Visible = false;

            DataTable dtGrade = DAL.GradeDal.getAll();
            cmbGrdSubgrd.DataSource = dtGrade;
            cmbGrdSubgrd.DisplayMember = "grade_name";
            cmbGrdSubgrd.ValueMember = "id";

            DataTable dtSubject = DAL.SubjectDal.getAll();
            cmbGrdSubSub.DataSource = dtSubject;
            cmbGrdSubSub.DisplayMember = "subject_name";
            cmbGrdSubSub.ValueMember = "id";
            cmbGrdSubgrd.Focus();
        }
        private void selectedRowValue()
        {
            if (dgvSubGrd.SelectedRows.Count > 0) {
                cmbGrdSubgrd.Text = dgvSubGrd.SelectedRows[0].Cells["grade_name"].Value.ToString();
                cmbGrdSubSub.Text = dgvSubGrd.SelectedRows[0].Cells["subject_name"].Value.ToString();
                this.id = dgvSubGrd.SelectedRows[0].Cells["id"].Value.ToString();
            }
        }
        private bool validateGradeSubject()
        {
            if (String.IsNullOrEmpty(cmbGrdSubgrd.Text))
            {
                MessageBox.Show("Select your Grade name!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGrdSubgrd.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(cmbGrdSubSub.Text))
            {
                MessageBox.Show("Select your Subject name!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGrdSubSub.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        private void btngrdsubDelete_Click(object sender, EventArgs e)
        {
            Int32 id=Convert.ToInt32(this.id);
            DialogResult dr=MessageBox.Show("Do you want delete?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            else
            {
                DAL.GradeSubject.delete(id);
                MessageBox.Show("Id :"+id+" details has been deleted Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btngrdsubAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew = true;
        }
        private void btngrdsubEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew = false;
        }
        private void btngrdsubSave_Click(object sender, EventArgs e)
        {
            

            
            if (is_addNew)
            {
                //insert
                if (validateGradeSubject())
                {
                    Int32 count = DAL.GradeSubject.countGradeSubjectRow(cmbGrdSubgrd.SelectedValue.ToString(), cmbGrdSubSub.SelectedValue.ToString());

                    if (count != 0)
                    {
                        MessageBox.Show("This is already exist");

                    }
                    else
                    {
                        DAL.GradeSubject.insert(cmbGrdSubgrd.SelectedValue.ToString(), cmbGrdSubSub.SelectedValue.ToString());
                        MessageBox.Show("Grade Subject details added successfully!");
                    }
                }


            }
            else
            {
                //update
                if (validateGradeSubject())
                {
                    int id = Convert.ToInt32(this.id);
                    int count = DAL.GradeSubject.countGradeSubjectUpdate(cmbGrdSubgrd.SelectedValue.ToString(), cmbGrdSubSub.SelectedValue.ToString(), id);
                    if (count != 0)
                    {
                        MessageBox.Show("This is already exist");

                    }
                    else
                    {
                        DAL.GradeSubject.update(cmbGrdSubgrd.SelectedValue.ToString(), cmbGrdSubSub.SelectedValue.ToString(), id);
                        MessageBox.Show("Grade Subject details updated successfully!");
                    }
                }
            }
            ButtonEnable(false);
        }
        private void btngrdsubCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Cancel", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            ButtonEnable(false);
        }
        private void btngrdsubExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtgrdsubSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void GradeSubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr= MessageBox.Show("Do you want close this?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) { 
                e.Cancel = true;
            }
        }
        private void dgvSubGrd_SelectionChanged(object sender, EventArgs e)
        {
            selectedRowValue();

        }

        private void btngrdsubRefresh_Click(object sender, EventArgs e)
        {
            formLoad();
            cmbGrdSubgrd.SelectedIndex = -1;
            cmbGrdSubSub.SelectedIndex = -1;
        }

        private void GradeSubjectForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }

    }
}
