using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Models
{
    public class UserModel
    {
        private string StudentNumber { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private string Status { get; set; }

        public UserModel() { }

        public UserModel(string _studentNumber, string _name, string _password, string _status)
        {
            StudentNumber = _studentNumber;
            Password = _password;
            Status = _status;

        }
        public string studentNumber { get { return StudentNumber; } set { StudentNumber = value; } }
        public string name { get { return Name; } set { Name = value; } }
        public string password { get { return Password; } set { Password = value; } }
        public string status { get { return Status; } set { Status = value; } }
    }
}
