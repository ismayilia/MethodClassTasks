using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Controller
{
    internal class AccountController
    {
        public void Login() 
        {
            
            Console.WriteLine("Add username");
            string username = Console.ReadLine();

            Console.WriteLine("Add password");
            string password = Console.ReadLine();

            Account account = new Account();
            account.Login(username, password);




        }
    }
}
