using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Controller
{
    internal class CalculatoController
    {
        public void Calculaten()
        {
            string[] operations = { "*", "/", "-", "+" };


            Console.WriteLine("Add number: ");
            decimal num1=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Add operation: (+, -, *, /)") ;
            Operation: string operation = Console.ReadLine(); 

            if (operations.Contains(operation))
            {


                Console.WriteLine("Add number: ");
                Num2: decimal num2 = Convert.ToDecimal(Console.ReadLine());

                if (operation == "/" && num2 == 0)
                {
                    Console.WriteLine("Can`t divde to zero, please add second number to again");
                    goto Num2;
                }

                Calculator calculator = new();
                calculator.Calculate(num1, operation, num2);
            }

            else
            {
                Console.WriteLine("Your operation wrong, please add correct operation");
                goto Operation;
            }
            

        }
    }
}
