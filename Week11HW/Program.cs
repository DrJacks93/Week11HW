using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using static System.Console;


namespace Week11HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double total = 0;
            string operation;

            WriteLine("Please enter a number for num1");
            num1 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter a number for num2");
            num2 = Convert.ToInt32(ReadLine());

            WriteLine("Please choose a math operation");
            WriteLine("1 - Addition");
            WriteLine("2 - Subtraction");
            WriteLine("3 - Multiply");
            WriteLine("4 - Divison");


            Console.Write("Enter operation (1/2/3/4): ");
            operation = Console.ReadLine();

            try
            {

                switch (operation)
                {
                    case "1":
                        total = num1 + num2;
                        break;
                    case "2":
                        total = num1 - num2;
                        break;
                    case "3":
                        total = num1 * num2;
                        break;
                    case "4":
                        total = num1 / num2;

                        break;

                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            WriteLine("Your total is: " + total);

        }
    }
}

