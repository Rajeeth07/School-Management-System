using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace School_Management_System.DAL
{
    public class StudentDal
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from students";
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
        public static void insert(String adNo, String fname, String lname, String fullName, String gender, DateTime dob, String nic, String phone, String gradeId, String medium, DateTime adDate, String address)
        {   

            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO[students](admission_no,[first_name],last_name,[full_name],gender,[date_of_birth],stu_nic_no,[tp_No],grade_id,[medium],date_of_addmission,[resident_address])VALUES('" + adNo + "','" + fname + "','" + lname + "','" + fullName + "','" + gender + "','" + dob + "','" + nic + "','" + phone + "','" + gradeId + "','" + medium + "','" + adDate + "','" +address + "')";
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
        public static void update(String adNo, String fname, String lname, String fullName, String gender, DateTime dob, String nic, String phone, String gradeId, String medium, DateTime adDate, String address, String id)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE[students] SET[admission_no] = '"+ adNo + "',[first_name] = '"+fname+"',[last_name] = '"+lname+"',[full_name] = '"+fullName+"',[gender] = '"+gender+"',[date_of_birth] = '"+dob+"',[stu_nic_no] = '"+nic+"',[tp_No] = '"+phone+"',[grade_id] = '"+gradeId+"',[medium] = '"+medium+"',[date_of_addmission] = '"+adDate+"',[resident_address] = '"+address+"' WHERE id = '"+id+"'";
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
                cmd.CommandText = "delete from students where id='"+id+"'";
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
        public static int countStudentRow(String adNo,String nic,String tp)
        {
            int counts = 0;
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM [students] where [admission_no]='" + adNo + "' or [stu_nic_no]='" + nic + "' or [tp_No]='"+ tp + "'";
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
