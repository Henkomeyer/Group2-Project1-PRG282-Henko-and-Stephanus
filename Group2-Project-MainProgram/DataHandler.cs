using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Group2_Project_MainProgram
{
    class DataHandler
    {
        public List<string> getuser(List<string> data)
        {
            List<string> Usernamereader = new List<string>();
            foreach (string line in data)
            {
                string[] items = line.Split(',');
                Usernamereader.Add(items[0]);
            }
            return Usernamereader;
        }

        public List<string> getpassword(List<string> data)
        {
            List<string> Passwordreader = new List<string>();
            foreach (string line in data)
            {
                string[] items = line.Split(',');
                Passwordreader.Add(items[1]);
            }
            return Passwordreader;
        }

        public DataHandler() { }
        string conn = "Server= (local); Initial Catalog= PRG_282_Project_Database; Integrated Security= true";
        public void AddStudent(int number, string name, byte[] image, DateTime dob, string gender, int phone, string address, string codes )
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("spAddStudent", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentNumber", number);
                    cmd.Parameters.AddWithValue("@StudentName", name);
                    cmd.Parameters.AddWithValue("@DoB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@ModuleCodes", codes);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }
        public void UpdateStudent(int number, string name, byte image, DateTime dob, string gender, int phone, string address, string codes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateStudent", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentNumber", number);
                    cmd.Parameters.AddWithValue("@StudentName", name);
                    cmd.Parameters.AddWithValue("@StudentImage", image);
                    cmd.Parameters.AddWithValue("@DoB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@ModuleCodes", codes);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "There was a problem with Updating this student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void DeleteStudent(int number)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteStudent", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentNumber", number);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        public DataTable SearchStudent(int number)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("spSearchStudent", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentNumber", number);
                    connection.Open();
                    DataTable dt = new DataTable();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "There was an error searching for a student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(er.Message);
            }
            
        }
        public void AddModule(string code, string name, string desc, string links)  // Code for adding a module to database
        {
            try
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
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message,"There was an error adding a module",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
        public void UpdateModule(int code, string name, string desc, string links)  // Code for updating a module
        {
            try
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
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "There was an error updating a module", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void DeleteModule(int code)  // Code for Deleting a module
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteModule", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModuleCode", code);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "There was an error updating a module", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchModule(int code) // Code for searcing for a module
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("spSearchModule", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModuleCode", code);
                    connection.Open();
                    DataTable dt = new DataTable();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
            catch (Exception er)
            {   
                MessageBox.Show(er.Message,"There was an error searching for the module",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw new Exception(er.Message);
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
        public DataTable DisplayModules()  // Code to diaplay a module
        {
            try
            {
                SqlConnection con = new SqlConnection(conn);
                SqlDataAdapter adapter = new SqlDataAdapter("spGetModules", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "There was an error displaying the modules", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(er.Message);
            }
        }
        //public byte[] convertImage()
        //{
        //    using (SqlConnection connection = new SqlConnection(conn))
        //    {
        //        StudentForm studentForm = new StudentForm();
        //        if (studentForm.pbxStudentImage.Image != null)
        //        {
        //            SqlCommand cmd = new SqlCommand("spAddStudent", connection);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            MemoryStream ms = new MemoryStream();
        //            ms = new MemoryStream();
        //            studentForm.pbxStudentImage.Image.Save(ms, ImageFormat.Jpeg);
        //            byte[] photo_aray = new byte[ms.Length];
        //            ms.Position = 0;
        //            ms.Read(photo_aray, 0, photo_aray.Length);
        //            cmd.Parameters.AddWithValue("@StudentImage", photo_aray);
        //            return photo_aray;
        //        }
        //    }
        //    return photo_aray;
        //}
    }


}
