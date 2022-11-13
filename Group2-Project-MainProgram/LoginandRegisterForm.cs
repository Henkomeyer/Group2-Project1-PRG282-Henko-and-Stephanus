using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Project_MainProgram
{
    public partial class LoginandRegisterForm : Form
    {
        DataHandler DataRead = new DataHandler();
        FileHandler Fileread = new FileHandler(); 
        public LoginandRegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();  
            reg.Show();
            this.Hide(); //Navigation between forms // Navigates to RegisterForm
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataRead.getuser(Fileread.Readfromlist()).Contains(tbxname.Text) && DataRead.getpassword(Fileread.Readfromlist()).Contains(tbxloginpass.Text))
                {
                    MessageBox.Show("Welcome {name} , enjoy your day", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CRUDOperationForm home = new CRUDOperationForm();
                    home.Show();
                    this.Hide(); //Navigation between forms /Navigates to base form/ CRUD FORM
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
           
        }

        private void btnseepass_Click(object sender, EventArgs e)
        {
            tbxloginpass.UseSystemPasswordChar = false;
            btnseepass.Visible = false; 
            btnhidepass.Visible = true;
        }

        private void btnhidepass_Click(object sender, EventArgs e)
        {
            tbxloginpass.UseSystemPasswordChar = true;
            
            btnseepass.Visible = true; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
