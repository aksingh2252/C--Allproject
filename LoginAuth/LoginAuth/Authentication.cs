using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuth
{
    public class Authentication
    {
        public bool userlogin(string username , string password)
        {
            if(string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
            {
                return false;

            }
            if(username=="Ankit" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getusername(String username)
        {
            return username;
        }
    }
}
