using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Account
    {
        public void Login(string username, string password)
        {
            if (username=="Cavid123"&& password=="cavid1993")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login successfuly");
            }
            else
            {
                Console.WriteLine("Email or password wrong");
            }
        }
    }
}
