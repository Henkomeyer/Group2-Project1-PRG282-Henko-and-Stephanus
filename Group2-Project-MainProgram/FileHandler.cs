using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms; 

namespace Group2_Project_MainProgram
{
    class FileHandler
    {
        public void WritetoText(List<string> GetText)
        {
            try
            {
                File.AppendAllLines("UserDetail.txt", GetText);
                MessageBox.Show("You are now Registered!","Welcome!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show( er.Message,"Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
