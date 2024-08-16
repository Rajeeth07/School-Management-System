using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.DAL
{
    public class GradeDal
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());


        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from grades";
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                cmd.Dispose();


            }
            catch (Exception)
            {

                throw;
            }
            finally { 
                con.Close();
            }
            return dt;
        }
        public static void getById(int id)
        {
            /*try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from grades";
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                cmd.Dispose();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }*/
            MessageBox.Show("this is grade detail with id!");
        }
        public static void insert(String GradeName,String GradeGroup, String GradeOrder)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO[grades](grade_name,[grade_group],grade_order)VALUES('" + GradeName + "','" + GradeGroup + "','" + GradeOrder + "')";
                if (con.State !=ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            
                cmd.Dispose();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            
        }
        public static void update(String GradeName, String GradeGroup, String GradeOrder, int id)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE[grades] SET [grade_name]='" + GradeName + "',[grade_group]='" + GradeGroup + "',[grade_order]='" + GradeOrder + "' WHERE id='" + id + "'";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                cmd.Dispose();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            
        }
        public static void delete(int id)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM grades WHERE id='" + id + "'";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                cmd.Dispose();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            
        }
        public static Int32 countAddValue(String grdGrp,String gradeName)
        {
            int counts = 0;
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM [grades] where [grades].grade_group='" + grdGrp + "' and [grades].grade_name='"+ gradeName + "'";
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                Int32 count = (Int32)cmd.ExecuteScalar();
                cmd.Dispose();
                counts = count;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return counts;
        }
    }
}
