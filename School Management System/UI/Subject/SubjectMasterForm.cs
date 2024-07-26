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
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            if (is_addNew)
            {
                //insert
               
                connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
                sql = "INSERT INTO[subjects](subject_name,[subject_index],subject_number,[subject_order])VALUES('"+txtSubName.Text+"','"+txtSubindex.Text+"','"+txtSubNumber.Text+"','"+txtSubOrder.Text+"')";
                connection = new SqlConnection(connetionString);
                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("Subject added successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
            else
            {
                //update
                /*connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
                sql = "UPDATE[subjects] SET [subject_name]='" + txtSubName.Text+"',[subject_index]='"+txtSubindex.Text+"',[subject_number]='"+txtSubNumber.Text+"',[subject_order]='" + txtSubName.Text + "' WHERE id='"+this.id+"'";
                connection = new SqlConnection(connetionString);
                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("Subject Updated successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open connection ! ");
                }*/
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
            DialogResult dr = MessageBox.Show("Do you want to delete Id: "+this.id+"?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            //Delete function
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;"; sql = "Your SQL Statemnt Here";
            sql = "delete from subjects where id='"+this.id+"'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Subject Id "+this.id+" details deleted successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnSubRefresh_Click(object sender, EventArgs e)
        {
            //Refresh function
            formLoad();
            txtSubNumber.Text=null;
            txtSubName.Text=null;
            txtSubindex.Text=null;
            txtSubOrder.Text=null;
            txtSubSearch.Text=null;

        }

        private void SubjectMasterForm_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void formLoad()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
            sql = "select * from subjects";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                dt= new DataTable();
                dt.Load(dataReader);
                dv = dt.DefaultView;
                dgvSub.DataSource = dv;
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void dgvSub_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSub.SelectedRows.Count > 0) {
                this.id=dgvSub.SelectedRows[0].Cells["id"].Value.ToString();
                txtSubName.Text = dgvSub.SelectedRows[0].Cells["subject_name"].Value.ToString();
                txtSubindex.Text = dgvSub.SelectedRows[0].Cells["subject_index"].Value.ToString();
                txtSubNumber.Text = dgvSub.SelectedRows[0].Cells["subject_number"].Value.ToString();
                txtSubOrder.Text = dgvSub.SelectedRows[0].Cells["subject_order"].Value.ToString();

            }
        }

        private void txtSubSearch_TextChanged(object sender, EventArgs e)
        {
            dv = new DataView(dt,"subject_name like '%"+txtSubSearch.Text+"%' or subject_index like '%"+txtSubindex.Text+"%' or subject_number like '%"+txtSubSearch.Text+"%'", "subject_name asc", DataViewRowState.CurrentRows);
            dgvSub.DataSource = dv;
        }
    }
}
