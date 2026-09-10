using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2, result;
            Console.WriteLine("Welcome to the Calculator!");

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt64(Console.ReadLine());
            /* Console.Readline() reads the user input from the console and returns it as a string.
             * Convert.ToInt64() converts the string input to an double. If the user enters a non-numerical value, this will throw a FormatException.
             */

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("What type of operation do you want to perform? (+, -, *, /)");
            Console.WriteLine("Enter a character:");

            result = Console.ReadLine()[0]; /* Read the first character of the input string */

                if (result == '+')
                {
                result = (num1 + num2);
                }
                else if (result == '-')
                {
                result = (num1 - num2);
                }
                else if (result == '*')
                {
                result = (num1 * num2);
                }
                else if (result == '/')
                {
                result = (num1 / num2);
                }

            Console.WriteLine("The result is: " + result);

            Console.ReadKey(); 
        }
    }





}
