using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Calculator
    {
        public void Calculate(decimal num1, string operation, decimal num2) 
        {
            decimal result;

           
            switch (operation)
            {
                case "+":
                    result = num1+num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                    break;

            }







        }
    }
}
