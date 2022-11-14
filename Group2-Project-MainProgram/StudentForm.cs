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

namespace Group2_Project_MainProgram
{
    public partial class StudentForm : Form
    {
        SqlConnection conn;
        public StudentForm()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();
        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            handler.AddStudent();
        }

        private void btnupdateinfo_Click(object sender, EventArgs e)
        {
            handler.UpdateStudent();
        }

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent();
        }

        private void btnsearchstudent_Click(object sender, EventArgs e)
        {
            handler.SearchStudent();
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
