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
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
            if (is_addNew)
            {
                
                sql = "INSERT INTO[grades](grade_name,[grade_group],grade_order)VALUES('" + txtGrdName.Text + "','" + txtGrdGroup.Text + "','" + txtGrdOrder.Text + "')";
                connection = new SqlConnection(connetionString);
                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("Grade detail added successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open connection ! ");
                }
            }
            else
            {
                sql = "UPDATE[grades] SET [grade_name]='" + txtGrdName.Text + "',[grade_group]='" + txtGrdGroup.Text + "',[grade_order]='" + txtGrdOrder.Text + "' WHERE id='" + this.id + "'";
                connection = new SqlConnection(connetionString);
                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("Grade detail updated successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open connection ! ");
                }

               
            }
        }

        private void btnGrdRefresh_Click(object sender, EventArgs e)
        {
            
            gridLoad();
            txtGrdName.Text = null;
            txtGrdGroup.Text = null;
            txtGrdOrder.Text = null;
        }

        private void btnGrdDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Do you want to delte?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel) { 
                return;
            }
            //delete function
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
            sql = "delete from grades where id='"+this.id+"'";
            connection = new SqlConnection(connetionString);
             try
             {
                 connection.Open();
                 command = new SqlCommand(sql, connection);
                 command.ExecuteNonQuery();
                 command.Dispose();
                 connection.Close();
                 MessageBox.Show("Grade detail deleted successfully");
             }
             catch (Exception)
             {
                 MessageBox.Show("Can not open connection ! ");
             }
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
        private void gridLoad()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Data Source=RAJEETH-ASUS\\SQLEXPRESS;Initial Catalog=Student_Management_System;Trusted_Connection=true;";
            sql = "select * from grades";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(dataReader);
                dv = dt.DefaultView;
                dgvGrd.DataSource = dv;
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void dgvGrd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrd.SelectedRows.Count > 0)
            {
                this.id = dgvGrd.SelectedRows[0].Cells["id"].Value.ToString();
                txtGrdName.Text = dgvGrd.SelectedRows[0].Cells["grade_name"].Value.ToString();
                txtGrdGroup.Text = dgvGrd.SelectedRows[0].Cells["grade_group"].Value.ToString();
                txtGrdOrder.Text = dgvGrd.SelectedRows[0].Cells["grade_order"].Value.ToString();
            }
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
