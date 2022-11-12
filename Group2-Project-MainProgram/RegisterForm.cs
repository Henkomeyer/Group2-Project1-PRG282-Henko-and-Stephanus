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
        LoginandRegisterForm back = new LoginandRegisterForm();
        List<string> temp = new List<string>();  //List for temporary reading
        FileHandler Filer = new FileHandler(); 
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e) // Button to open Login Form
        {
            
            back.Show();
            this.Hide(); //Navigation between forms
        }

        private void btnreg_Click(object sender, EventArgs e) //Submit Registration Button
        {

            if (tbxconfirmpass.Text != "" || tbxname.Text != ""|| tbxconfirmpass.Text != "")
            {
                if (tbxpassword.Text != tbxconfirmpass.Text)
                {
                    MessageBox.Show( "The Password does not match, please try again!","Error with Passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxpassword.Clear();
                    tbxconfirmpass.Clear();
                }
                else
                {
                    UserDetail user = new UserDetail(tbxname.Text, tbxpassword.Text);
                    temp.Add(user.Storeinfo());
                    Filer.WritetoText(temp);
                    this.Hide();
                    back.Show(); 

                }
            }
            else
            {
                MessageBox.Show("One of the Fields is empty", "Commit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
