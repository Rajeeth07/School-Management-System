using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace School_Management_System.DAL
{
    public class SubjectDal
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from subjects";
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

        }
        public static void insert(String subName,int subIndex, String subNumber,int subOrder)
        {
            
            try
            {
                SqlCommand cmd = con.CreateCommand();
                
                cmd.CommandText = "INSERT INTO[subjects](subject_name,[subject_index],subject_number,[subject_order])VALUES('" + subName + "','" + subIndex + "','" + subNumber + "','" + subOrder + "')";
                if (con.State != System.Data.ConnectionState.Open)
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
        public static void update(String subName,int subIndex, String subNumber,int subOrder,int id)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "UPDATE [subjects] SET [subject_name]='" + subName + "',[subject_index]='" + subIndex + "',[subject_number]='" + subNumber + "',[subject_order]='" + subOrder + "' WHERE id='" + id + "'";
                if (con.State != System.Data.ConnectionState.Open)
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

                cmd.CommandText = "DELETE FROM subjects WHERE id='" + id + "'";
                if (con.State != System.Data.ConnectionState.Open)
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
        public static Int32 countAddValue(String subName)
        {
            int counts = 0;
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM [subjects] where [subjects].subject_name='" + subName + "'";
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
