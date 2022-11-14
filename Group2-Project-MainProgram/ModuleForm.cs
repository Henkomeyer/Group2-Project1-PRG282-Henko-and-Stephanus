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
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();

        private void btnBackModule_Click(object sender, EventArgs e)
        {
            CRUDOperationForm form = new CRUDOperationForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            handler.AddModule(int.Parse(tbxModuleCode.Text),tbxModuleName.Text, tbxModuleDescription.Text, tbxResourceLinks.Text);
            MessageBox.Show("Module has been successfulyl added");
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            handler.UpdateModule(int.Parse(tbxModuleCode.Text), tbxModuleName.Text, tbxModuleDescription.Text, tbxResourceLinks.Text);
            MessageBox.Show("Module has been successfulyl Updated");
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            handler.DeleteModule(int.Parse(tbxModuleCode.Text));
            MessageBox.Show("Module has been succesfully deleted");
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.SearchModule(int.Parse(tbxModuleCode.Text));
        }

        private void btnDisplayModules_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.DisplayModules();
        }
    }
}
