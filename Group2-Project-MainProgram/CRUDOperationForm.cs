using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Project_MainProgram
{
    public partial class CRUDOperationForm : Form
    {
        public CRUDOperationForm()
        {
            InitializeComponent();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnaddmodule_Click(object sender, EventArgs e)
        {
            ModuleForm form = new ModuleForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
