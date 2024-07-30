using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
        public static void insert(String subName, String subIndex, String subNumber, String subOrder)
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
        public static void update(String subName, String subIndex, String subNumber, String subOrder,int id)
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
    }
}
