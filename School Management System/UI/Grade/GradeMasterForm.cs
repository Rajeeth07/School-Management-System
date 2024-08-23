using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.Grade
{
    public partial class GradeMasterForm : Form
    {
        String id;
        Boolean is_addNew = false;
        DataTable dt=new DataTable();
        DataView dv;
        public GradeMasterForm()
        {
            InitializeComponent();
        }

        #region User Define functions
        private void gridLoad()
        {   
            dt = DAL.GradeDal.getAll();
            dv = dt.DefaultView;
            dgvGrd.DataSource = dv;
            
        }
        private void selectedRowValues()
        {
            if (dgvGrd.SelectedRows.Count > 0)
            {
                this.id = dgvGrd.SelectedRows[0].Cells["id"].Value.ToString();
                txtGrdName.Text = dgvGrd.SelectedRows[0].Cells["grade_name"].Value.ToString();
                txtGrdGroup.Text = dgvGrd.SelectedRows[0].Cells["grade_group"].Value.ToString();
                txtGrdOrder.Text = dgvGrd.SelectedRows[0].Cells["grade_order"].Value.ToString();
            }
        }
        private void ButtonEnable(bool is_true)
        {
            
            btnGrdAdd.Enabled = !is_true;
            btnGrdEdit.Enabled = !is_true;
            btnGrdDelete.Enabled = !is_true;
            btnGrdRefresh.Enabled = !is_true;
            btnGrdExit.Enabled = !is_true;

            btnGrdSave.Enabled = is_true;
            btnGrdCancel.Enabled = is_true;
        }
        private void doEmptyForm()
        {
            txtGrdName.Text = null;
            txtGrdGroup.Text = null;
            txtGrdOrder.Text = null;
            txtGrdSearch.Text = null;
        }
        private bool ValidateGrade()
        {
            if (String.IsNullOrEmpty(txtGrdName.Text))
            {
                MessageBox.Show("please enter the  Grade Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrdName.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtGrdGroup.Text))
            {
                MessageBox.Show("please enter the  Grade group", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrdGroup.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtGrdOrder.Text))
            {
                MessageBox.Show("please enter the  grade group", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrdOrder.Focus();
                return false;
            }
            int num = 0;
            Boolean isNumber1 = Int32.TryParse(txtGrdOrder.Text, out num);
            if (!isNumber1)
            {
                MessageBox.Show("Grade Order shoud be a number value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrdOrder.Focus();
                return false;

            }
            if (String.IsNullOrEmpty(txtGrdName.Text))
            {
                MessageBox.Show("Grade Name field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrdName.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtGrdGroup.Text))
            {
                MessageBox.Show("Grade group field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrdGroup.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtGrdOrder.Text))
            {
                MessageBox.Show("Grade order field can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrdOrder.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        private void btnGrdAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew = true;
        }
        private void btnGrdCancel_Click(object sender, EventArgs e)
        {   
            DialogResult dr=MessageBox.Show("Do you want to cancel?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            ButtonEnable(false);
        }
        private void btnGrdEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew=false;
        }
        private void btnGrdSave_Click(object sender, EventArgs e)
        {
            ButtonEnable(false);
            if (is_addNew)
            {

                if (ValidateGrade())
                {
                    Int32 count = DAL.GradeDal.countAddValue(txtGrdName.Text.Trim(), txtGrdOrder.Text.Trim());
                    if (count != 0)
                    {
                        MessageBox.Show("This is already exist");
                    }
                    else
                    {
                        DAL.GradeDal.insert(txtGrdName.Text.Trim(), txtGrdGroup.Text.Trim(), txtGrdOrder.Text.Trim());
                        MessageBox.Show("Grade added successfully");
                    }
                }

            }
            else
            {
                if (ValidateGrade())
                {
                    int id = Convert.ToInt32(this.id);
                    int count = DAL.GradeDal.countGradeUpdate(txtGrdName.Text.Trim(), txtGrdOrder.Text.Trim(), id);
                    if (count != 0)
                    {
                        MessageBox.Show("this is already exist");
                    }
                    else
                    {
                        DAL.GradeDal.update(txtGrdName.Text.Trim(), txtGrdGroup.Text.Trim(), txtGrdOrder.Text.Trim(), id);
                        MessageBox.Show("Grade Id : " + id + " details updated!");
                    }
                }

            }
        }
        private void btnGrdRefresh_Click(object sender, EventArgs e)
        {
            gridLoad();
            doEmptyForm();
        }
        private void btnGrdDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete Id: " + this.id + "?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            int id;
            
            id = Convert.ToInt32(this.id);
            DAL.GradeDal.delete(id);
            MessageBox.Show("Grade id : "+id+" details deleted successfully");
            
        }
        private void btnGrdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GradeMasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void GradeMasterForm_Load(object sender, EventArgs e)
        {
            gridLoad();
        }
        private void dgvGrd_SelectionChanged(object sender, EventArgs e)
        {
            selectedRowValues();
        }
        private void txtGrdSearch_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                dv = new DataView(dt, "grade_name LIKE '%" + txtGrdSearch.Text + "%' or grade_group LIKE '%" + txtGrdSearch.Text + "%' ", "grade_name asc", DataViewRowState.CurrentRows);
                dgvGrd.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open");
                throw;
            }
     
        }

        
    }
}
