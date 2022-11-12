using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Project_MainProgram
{ 
    class DataHandler
    {   
        
        public List<string> getuser(List<string> data)
        { List<string> Usernamereader = new List<string>();  
            foreach (string line in data)
            {
                string[] items = line.Split(',');
                Usernamereader.Add(items[0]);
            }
            return Usernamereader;
        }

        public List<string> getpassword(List<string> data)
        { List<string> Passwordreader = new List<string>();
            foreach (string line in data)
            {
                string[] items = line.Split(',');
                Passwordreader.Add(items[1]);
            }
            return Passwordreader;
        }
        
    }
}
