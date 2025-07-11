using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuth
{
    public class Authentication
    {
        public String userlogin(String username, String password)
        {
            if(String.IsNullOrEmpty(username)|| String.IsNullOrEmpty(password))
            {
                return "Username and Password can't be Empty";
            }
            if(username=="admin" && password == "123")
            {
                return getUserName(username);
            }
            else
            {
                return "Username and Password  is Incorrect";
            }

           

        }
        public string getUserName(string username)
        {
            return username;
        }


    }
}
