using System;
using System.Data;
using System.Windows.Forms;

namespace School_Management_System.UI.Subject
{
    public partial class SubjectMasterForm : Form
    {
        Boolean is_addNew=false;
        DataTable dt=new DataTable();
        DataView dv;
        String id;
        public SubjectMasterForm()
        {
            InitializeComponent();
        }
        #region User Define Functions
        private void ButtonEnable(bool is_true)
        {
            is_addNew = is_true;
            btnSubAdd.Enabled = !is_true;
            btnSubDelete.Enabled = !is_true;
            btnSubEdit.Enabled = !is_true;
            btnSubExit.Enabled = !is_true;
            btnSubRefresh.Enabled = !is_true;

            btnSubSave.Enabled = is_true;
            btnSubCancel.Enabled = is_true;
        }
        private bool validatesSubject()
        {
            if (String.IsNullOrEmpty(txtSubName.Text))
            {
                MessageBox.Show("please enter the  subject Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubName.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSubindex.Text))
            {
                MessageBox.Show("please enter the  subject Index", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubindex.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSubNumber.Text))
            {
                MessageBox.Show("please enter the  subject Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubNumber.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtSubOrder.Text))
            {
                MessageBox.Show("please enter the  subject order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubOrder.Focus();
                return false;
            }
            int num = 0;
            Boolean isNumber1 = Int32.TryParse(txtSubOrder.Text, out num);
            if (!isNumber1)
            {
                MessageBox.Show("Subject Order shoud be a number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubOrder.Focus();
                return false;

            }
            else
            {
                return true;
            }
        }
        private void selectedValues()
        {
            if (dgvSub.SelectedRows.Count > 0)
            {
                this.id = dgvSub.SelectedRows[0].Cells["id"].Value.ToString();
                txtSubName.Text = dgvSub.SelectedRows[0].Cells["subject_name"].Value.ToString();
                txtSubindex.Text = dgvSub.SelectedRows[0].Cells["subject_index"].Value.ToString();
                txtSubNumber.Text = dgvSub.SelectedRows[0].Cells["subject_number"].Value.ToString();
                txtSubOrder.Text = dgvSub.SelectedRows[0].Cells["subject_order"].Value.ToString();

            }
        }
        private void doEmptyformFill()
        {
            txtSubNumber.Text = null;
            txtSubName.Text = null;
            txtSubindex.Text = null;
            txtSubOrder.Text = null;
            txtSubSearch.Text = null;
        }
        private void formLoad()
        {
            dt = DAL.SubjectDal.getAll();
            dv=dt.DefaultView;
            dgvSub.DataSource = dv;
            txtSubName.Focus();
        }
        #endregion
        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            
        }
        private void btnSubEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew=false;
        }
        private void btnSubSave_Click(object sender, EventArgs e)
        {
            if (is_addNew)
            {

                //insert
                if (validatesSubject())
                {
                    Int32 count = DAL.SubjectDal.countAddValue(txtSubName.Text.Trim(), Convert.ToInt32(txtSubindex.Text), txtSubNumber.Text.Trim(), Convert.ToInt32(txtSubOrder.Text));

                    if (count != 0)
                    {
                        MessageBox.Show("This is already exist");
                    }
                    else
                    {
                        DAL.SubjectDal.insert(txtSubName.Text.Trim(), Convert.ToInt32(txtSubindex.Text), txtSubNumber.Text.Trim(), Convert.ToInt32(txtSubOrder.Text));
                        MessageBox.Show("Subject details added successfully!");
                    }
                }
            }
            else
            {
                //update
                if (validatesSubject())
                {
                    int id = Convert.ToInt32(this.id);
                    int count = DAL.SubjectDal.countUpdateValue(txtSubName.Text.Trim(), Convert.ToInt32(txtSubindex.Text), txtSubNumber.Text.Trim(), Convert.ToInt32(txtSubOrder.Text), id);
                    if (count != 0)
                    {
                        MessageBox.Show("This is already exist");
                    }
                    else
                    {
                        DAL.SubjectDal.update(txtSubName.Text.Trim(), Convert.ToInt32(txtSubindex.Text), txtSubNumber.Text.Trim(), Convert.ToInt32(txtSubOrder.Text), id);
                        MessageBox.Show("Subject id : " + id + " details updated successfully!");
                    }
                }
            }
            ButtonEnable(false);
        }
        private void btnSubCancel_Click(object sender, EventArgs e)
        {   
            DialogResult dr=MessageBox.Show("Do you want to Cancel","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.No)
            {
                return;
            }
            ButtonEnable(false);
        }
        private void SubjectMasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr=MessageBox.Show("Do you want to close?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) { 
                e.Cancel = true;
            }
        }
        private void btnSubExit_Click(object sender, EventArgs e)
        {
               this.Close();
        }
        private void btnSubDelete_Click(object sender, EventArgs e)
        {   
            int id=Convert.ToInt32(this.id);
            DialogResult dr = MessageBox.Show("Do you want to delete Id: "+this.id+"?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            //Delete function
            DAL.SubjectDal.delete(id);
            MessageBox.Show("Subject Id : " + id + " details deleted successfully!");
        }
        private void btnSubRefresh_Click(object sender, EventArgs e)
        {
            //Refresh function
            formLoad();
            doEmptyformFill();

        }
        private void SubjectMasterForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }
        private void dgvSub_SelectionChanged(object sender, EventArgs e)
        {
            selectedValues();
        }
        private void txtSubSearch_TextChanged(object sender, EventArgs e)
        {
            dv = new DataView(dt,"subject_name like '%"+txtSubSearch.Text+"%' or subject_index like '%"+txtSubindex.Text+"%' or subject_number like '%"+txtSubSearch.Text+"%'", "subject_name asc", DataViewRowState.CurrentRows);
            dgvSub.DataSource = dv;
        }
    }
}
