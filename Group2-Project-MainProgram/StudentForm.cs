using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Group2_Project_MainProgram
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentNumber.Text != "" && tbxStudentName.Text != "" || tbxStudentPhone.Text != "" || tbxStudentAddress.Text != "" || tbxStudentModule.Text != "")
            {
                handler.AddStudent(int.Parse(tbxStudentNumber.Text), tbxStudentName.Text, handler.convertImage(), dtpStudentDoB.Value, cbxGender.Text, int.Parse(tbxStudentPhone.Text), tbxStudentAddress.Text, tbxStudentModule.Text); 
            }
            else
            {
                MessageBox.Show("One or more of the fields are empty", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnupdateinfo_Click(object sender, EventArgs e)
        {
            if (tbxStudentNumber.Text != "" && tbxStudentName.Text != "" || tbxStudentPhone.Text != "" || tbxStudentAddress.Text != "" || tbxStudentModule.Text != "")
            {
                handler.AddStudent(int.Parse(tbxStudentNumber.Text), tbxStudentName.Text, handler.convertImage(), dtpStudentDoB.Value, cbxGender.Text, int.Parse(tbxStudentPhone.Text), tbxStudentAddress.Text, tbxStudentModule.Text); 
            }
            else
            {
                MessageBox.Show("One or more of the fields are empty", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentNumber.Text != "")
            {
                try
                {
                   handler.DeleteStudent(int.Parse(tbxStudentNumber.Text));
                }
                catch (Exception er)
                {
                   MessageBox.Show(er.Message,"Commit Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Input a student Number that you would like to delete", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsearchstudent_Click(object sender, EventArgs e)
        {
            if (tbxSearchStudent.Text != "") 
            {
                try
                {
                  dataGridView1.DataSource = handler.SearchStudent(int.Parse(tbxSearchStudent.Text));
                }
                catch (Exception er)
                {

                  MessageBox.Show(er.Message, "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Input the Student Number for the student you are searching for", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBackStudent_Click(object sender, EventArgs e) // Back Button
        {
            CRUDOperationForm form = new CRUDOperationForm();
            form.Show();
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayStudents();
        }
    }
}
