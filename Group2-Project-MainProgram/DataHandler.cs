using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Group2_Project_MainProgram
{
    class DataHandler
    {
        public DataHandler() { }
        string conn = "Server= (local); Initial Catalog= PRG_282_Project_Database; Integrated Security= true";
        public void AddStudent()
        {
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Opened");
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            string query = @"INSERT INTO [Student Info] ([Student Number], [Student Name and Surname], [Student Image], DoB, Gender, Phone, Address, [Module Codes]) VALUES (tbxStudentNumber.text, tbxStudentName.text, pbxStudentImage, dtpStudentDoB, cbxGender.text, tbxStudentPhone.text, tbxStudentAddress.text, tbxStudentModule.text)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student has been successfully added.");
            connection.Close();
        }
        public void UpdateStudent()
        {
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Opened");
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            string query = @"UPDATE [Student Info] ([Student Number], [Student Name and Surname], [Student Image], DoB, Gender, Phone, Address, [Module Codes]) VALUES (tbxStudentNumber.text, tbxStudentName.text, pbxStudentImage, dtpStudentDoB, cbxGender.text, tbxStudentPhone.text, tbxStudentAddress.text, tbxStudentModule.text) ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student's information has been successfully Updated");
            connection.Close();
        }
        public void DeleteStudent()
        {
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Opened");
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            string query = @"DELETE FROM [Student Info] WHERE [Student Number]= tbxStudentNumber.text";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student information has been successfully deleted");
            connection.Close();
        }
        public void SearchStudent()
        {
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Opened");
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            string query = @"SELECT * FROM [Student Info] WHERE [Student Number]= tbxSearchStudent.text";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void AddModule(int code, string name, string desc, string links)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddModules", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", code);
                cmd.Parameters.AddWithValue("@ModuleName", name);
                cmd.Parameters.AddWithValue("@ModuleDesc", desc);
                cmd.Parameters.AddWithValue("@ModuleLinks", links);
                connection.Open();
                cmd.ExecuteNonQuery ();
            }
        }
        public void UpdateModule(int code, string name, string desc, string links)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateModule", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", code);
                cmd.Parameters.AddWithValue("@ModuleName", name);
                cmd.Parameters.AddWithValue("@ModuleDesc", desc);
                cmd.Parameters.AddWithValue("@ModuleLinks", links);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteModule(int code)
        {
            using(SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand ("spDeleteModule", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", code);
                connection.Open ();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable SearchModule(int code)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchModule", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", code);
                connection.Open();
                DataTable dt = new DataTable();
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable DisplayStudents()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudents", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable DisplayModules()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetModules", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
