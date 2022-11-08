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
    public partial class LoginandRegisterForm : Form
    {
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
            CRUDOperationForm home = new CRUDOperationForm();
            home.Show();
            this.Hide(); //Navigation between forms /Navigates to base form/ CRUD FORM
        }
    }
}
