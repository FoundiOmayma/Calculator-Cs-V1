using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            string answer;
            int result =0;

            Console.WriteLine("Hello, Welcome to the calculator program!");
            Console.WriteLine("Enter your first number: ");

            //casting because Console.ReadLine() return a string 
            num1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            //operations
            Console.WriteLine("Press a for addiction, s for subtraction, m for multiplication and d for division");
            Console.WriteLine("What type of operation would you like to do: ");

            answer = Console.ReadLine();
            try
            {
                if (answer == "a")
                {
                    result = num1 + num2;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                }
                else if (answer == "d")
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Impossible to divide by 0!");
                    }
                }
                else
                {
                    Console.WriteLine("Please choose one of the options given!");
                    return;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return; 
            }


            Console.WriteLine("The result of your operation is : " + result);
            Console.ReadKey();
        }
    }
}
