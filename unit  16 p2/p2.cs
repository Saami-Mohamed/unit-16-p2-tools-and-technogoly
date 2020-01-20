﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Tools_Technique
{
    class Program
    {
        static void Main(string[] args)
        {
            //I have declared the vairables below
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;
            float answer;

            //While loop is added to stop program closing
            while (true)
            {// ask user for their first number
                Console.Write("Please enter the first integer: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                // ask user for their second number
                Console.Write("Please enter the second integer: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                // ask user operation to use
                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n Do You Want To Break (Y/y)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();

            }
        }
}
