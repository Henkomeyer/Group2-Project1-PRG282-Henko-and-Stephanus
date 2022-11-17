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

        private void btnBackModule_Click(object sender, EventArgs e) // Button for going back
        {
            CRUDOperationForm form = new CRUDOperationForm();
            form.Show();
            this.Close();
        }

        private void btnAddModule_Click(object sender, EventArgs e) // Button for adding a module
        {
            if ((tbxModuleCode.Text != "" && tbxModuleName.Text != "") || tbxModuleDescription.Text != "" || tbxResourceLinks.Text != "" )
            {
                handler.AddModule(tbxModuleCode.Text, tbxModuleName.Text, tbxModuleDescription.Text, tbxResourceLinks.Text);
            }
            else
            {
                MessageBox.Show("One or more of the fields are empty","Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            if ((tbxModuleName.Text != "" && tbxModuleCode.Text != "") || tbxModuleDescription.Text != "" || tbxResourceLinks.Text != "")
            {
                handler.UpdateModule(int.Parse(tbxModuleCode.Text), tbxModuleName.Text, tbxModuleDescription.Text, tbxResourceLinks.Text);
            }
            else
            {
                MessageBox.Show("One or more of the fields are empty", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            if (tbxModuleCode.Text != "")
            {
                try
                {
                  handler.DeleteModule(int.Parse(tbxModuleCode.Text));
                }
                catch (Exception er)
                {

                    MessageBox.Show(er.Message, "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Input a module code that you would like to delete", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            if (tbxSearchModule.Text != "")
            {
                try
                {
                  dataGridView1.DataSource = handler.SearchModule(int.Parse(tbxModuleCode.Text));
                }
                catch (Exception er)
                {

                    MessageBox.Show(er.Message, "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Input a module code that you would like to Search for", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayModules_Click(object sender, EventArgs e)
        {
                dataGridView1.DataSource = handler.DisplayModules();
        }
    }
}
