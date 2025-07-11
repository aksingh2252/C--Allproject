using System;
using System.ComponentModel.Design;
using System.Xml.Schema;
namespace BatchConsole12PM
{
    class Authentication
    {
        public bool check_Login(string username, string password)
        {
            bool jyoti = false;
            if (username == "admin" && password == "123")
            {
                jyoti = true;
            }
            else
            {
                return jyoti;
            }
            return jyoti;
        }
    }
    class Demo
    {
        static void Main()
        {
            int attempts = 0;
            char choice;
            DateTime StartTime = DateTime.Now;


            do
            {

                Authentication auth = new Authentication();
                Console.WriteLine("Enter UserName and Password=>>");

                string u_name = Console.ReadLine();
                string u_paswd = Console.ReadLine();

                bool b = auth.check_Login(u_name, u_paswd);
                if (b == true)
                {
                    Console.WriteLine("Login SuccessFully!!");
                    break;
                    if ((DateTime.Now - StartTime).TotalMinutes >= 2)
                    {
                        Console.WriteLine("Login session expired after 30 minutes. Please try again later.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Login Failed!!!");
                    attempts++;
                }

                if (attempts >= 3)
                {
                    Console.WriteLine("Maximum login attempts reached. Exiting...");
                    break;
                }
                Console.WriteLine("Do you wish to continue (Y/N)??");
                choice = Convert.ToChar(Console.ReadLine());
            }
            while (choice == 'y' || choice == 'Y');
        }
    }
}