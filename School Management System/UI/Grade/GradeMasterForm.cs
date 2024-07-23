using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.Grade
{
    public partial class GradeMasterForm : Form
    {
        Boolean is_addNew = false;
        public GradeMasterForm()
        {
            InitializeComponent();
        }
        private void ButtonEnable(bool is_true)
        {
            is_addNew = is_true;
            btnGrdAdd.Enabled = !is_true;
            btnGrdEdit.Enabled = !is_true;
            btnGrdDelete.Enabled = !is_true;
            btnGrdRefresh.Enabled = !is_true;
            btnGrdExit.Enabled = !is_true;

            btnGrdSave.Enabled = is_true;
            btnGrdCancel.Enabled = is_true;
        }

        private void btnGrdAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
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
                //insert
            }
            else
            {
                //update
            }
        }

        private void btnGrdRefresh_Click(object sender, EventArgs e)
        {
            //refresh function
        }

        private void btnGrdDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Do you want to delte?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) { 
                return;
            }
            //delete function
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
    }
}
