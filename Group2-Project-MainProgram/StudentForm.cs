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
            handler.AddStudent(int.Parse(tbxStudentNumber.Text), tbxStudentName.Text, handler.convertImage(), dtpStudentDoB.Value, cbxGender.Text, int.Parse(tbxStudentPhone.Text), tbxStudentAddress.Text, tbxStudentModule.Text); ;
            MessageBox.Show("Student added successfully");
        }

        private void btnupdateinfo_Click(object sender, EventArgs e)
        {
            handler.UpdateStudent(int.Parse(tbxStudentNumber.Text), tbxStudentName.Text, pbxStudentImage, dtpStudentDoB.Value, cbxGender.Text, int.Parse(tbxStudentPhone.Text), tbxStudentAddress.Text, tbxStudentModule.Text);
            MessageBox.Show("Student updated successfully");
        }

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent(int.Parse(tbxStudentNumber.Text));
            MessageBox.Show("Student has been deleted");
        }

        private void btnsearchstudent_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.SearchStudent(int.Parse(tbxSearchStudent.Text));
        }

        private void btnBackStudent_Click(object sender, EventArgs e)
        {
            CRUDOperationForm form = new CRUDOperationForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayStudents();
        }
    }
}
