using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.DAL
{
    public class GradeSubject
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());


        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select [grade_subject].[id],[grade_id],[grades].[grade_name],[subject_id],[subjects].[subject_name] from grade_subject INNER JOIN grades ON [grade_subject].grade_id=[grades].id INNER JOIN subjects ON [grade_subject].subject_id=[subjects].id";
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
        public static void insert(String grdId, String subId)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO[grade_subject]([grade_id],[subject_id])VALUES('" + grdId + "','" + subId + "')";
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
        public static void update(String grdId, String subId, int id)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE[grade_subject] SET [grade_id]='" + grdId + "',[subject_id]='" + subId + "' WHERE id='" + id + "'";
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
                cmd.CommandText = "DELETE FROM grade_subject WHERE id='" + id + "'";
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
        public static Int32 countGradeSubjectRow(String grdId, String subId)
        {
            int counts = 0;
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM [grade_subject] where [grade_subject].grade_id='"+grdId+ "' and [grade_subject].subject_id='"+ subId + "'";
               if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                Int32 count = (Int32)cmd.ExecuteScalar();
                cmd.Dispose();
                counts=count;

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

        public static Int32 countGradeSubjectUpdate(String grdId, String subId, int id)
        {
            int counts = 0;
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM [grade_subject] where [grade_subject].grade_id='" + grdId + "' and [grade_subject].subject_id='" + subId + "' and [id]!='"+id+"'";
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

