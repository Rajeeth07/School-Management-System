using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.UI.Subject
{
    public partial class SubjectMasterForm : Form
    {
        Boolean is_addNew=false;
        public SubjectMasterForm()
        {
            InitializeComponent();
        }
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
            }
            else
            {
                //update
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
            DialogResult dr = MessageBox.Show("Do you want to delete?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            //Delete function
        }

        private void btnSubRefresh_Click(object sender, EventArgs e)
        {
            //Refresh function
        }
    }
}
