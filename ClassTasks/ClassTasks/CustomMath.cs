using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasks
{
    internal class CustomMath
    {

       
        public int GetSumOfArraySingleNumbers(int[] arr)
        {
            int sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2==1)
                {
                    sum += arr[i];
                }
              
            }
            return sum;
        }



        public void SingleOrDoubleNumbers(int a)
        {
            if (a % 2 == 1 && a>0)
            {
                Console.WriteLine("This is single number");
            }
            else if (a % 2 == 0 && a!= 0 && a>0)
            {
                Console.WriteLine("This is double number");
            }
            else if (a == 0)
            {
                Console.WriteLine("Zero is neither positive nor negative");
            }
            else
            {
                Console.WriteLine("Please add positive number");
            }

        }





        public int ArrayNumbersSumOfSquare(int[] arr)
        {
            int sum = 0;
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    sum += arr[i];
                    
                }
            }
            result = sum * sum;
            return result;
        }


        public void NumbersOfMultiplication(int n)
        {
            int result = 1;
            for (int i = 1; i<n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }






























    }
}
