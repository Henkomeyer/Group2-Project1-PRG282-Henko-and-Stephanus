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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e) // Button to open Login Form
        {
            LoginandRegisterForm back = new LoginandRegisterForm();
            back.Show();
            this.Hide(); //Navigation between forms
        }

        private void btnreg_Click(object sender, EventArgs e) //Submit Registration Button
        {
            if (tbxpassword.Text != tbxconfirmpass.Text)
            {
                MessageBox.Show("Error with Passwords", "The Password does not match, please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                tbxpassword.Clear();
                tbxconfirmpass.Clear(); 
            }
        }
    }
}
