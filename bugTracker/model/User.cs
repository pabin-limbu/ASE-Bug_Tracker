using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bugTracker.model
{
    public class User
    {
       int id;
         string fname;
        string lname;
        string username;
        string password;
        string userType;
        string email;
        string gender;

        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string UserType { get => userType; set => userType = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
