using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMiniräknareInlämningsuppgiftZeynab
{
    class Program
    {
        static void Main(string[] args)
        {
            char restart = 'y';
            
            while (true)
            {

                Console.WriteLine("Calculator using two operators");
                
                Console.Write(">Enter first number: ");
                
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write(">Enter first operator: ");
                char op1 = Console.ReadKey().KeyChar;

                Console.Write("\n>Enter a second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write(">Enter second operator: ");
                char op2 = Console.ReadKey().KeyChar;

                Console.Write("\n>Enter a third number: ");
                double num3 = Convert.ToDouble(Console.ReadLine());

                if (op1 == '+' && op2 == '+')
                {
                    Console.Write("{0} + {1} + {2} = ", num1, num2, num3);
                    Console.Write(num1 + num2 + num3);

                }
                else if (op1 == '+' && op2 == '-')
                {
                    Console.Write("{0} + {1} - {2} = ", num1, num2, num3);
                    Console.Write(num1 + num2 - num3);
                }
                else if (op1 == '+' && op2 == '*')
                {
                    Console.Write("{0} + {1} * {2} = ", num1, num2, num3);
                    Console.Write(num1 + num2 * num3);
                }
                else if (op1 == '+' && op2 == '/')
                {
                    Console.Write("{0} + {1} / {2} = ", num1, num2, num3);
                    Console.Write(num1 + num2 / num3);
                }
                else if (op1 == '-' && op2 == '-')
                {
                    Console.Write("{0} - {1} - {2} = ", num1, num2, num3);
                    Console.Write(num1 - num2 - num3);
                }
                else if (op1 == '-' && op2 == '+')
                {
                    Console.Write("{0} - {1} + {2} = ", num1, num2, num3);
                    Console.Write(num1 - num2 + num3);
                }
                else if (op1 == '-' && op2 == '*')
                {
                    Console.Write("{0} - {1} * {2} = ", num1, num2, num3);
                    Console.Write(num1 - num2 * num3);
                }
                else if (op1 == '-' && op2 == '/')
                {
                    Console.Write("{0} - {1} / {2} = ", num1, num2, num3);
                    Console.Write(num1 - num2 / num3);
                }
                else if (op1 == '*' && op2 == '*')
                {
                    Console.Write("{0} * {1} * {2} = ", num1, num2, num3);
                    Console.Write(num1 * num2 * num3);
                }
                else if (op1 == '*' && op2 == '+')
                {
                    Console.Write("{0} * {1} + {2} = ", num1, num2, num3);
                    Console.Write(num1 * num2 + num3);
                }
                else if (op1 == '*' && op2 == '-')
                {
                    Console.Write("{0} * {1} - {2} = ", num1, num2, num3);
                    Console.Write(num1 * num2 - num3);
                }
                else if (op1 == '*' && op2 == '/')
                {
                    Console.Write("{0} * {1} / {2} = ", num1, num2, num3);
                    Console.Write(num1 * num2 / num3);
                }
                else if (op1 == '/' && op2 == '/')
                {
                    Console.Write("{0} / {1} / {2} = ", num1, num2, num3);
                    Console.Write(num1 / num2 / num3);
                }
                else if (op1 == '/' && op2 == '+')
                {
                    Console.Write("{0} / {1} + {2} = ", num1, num2, num3);
                    Console.Write(num1 / num2 + num3);
                }
                else if (op1 == '/' && op2 == '-')
                {
                    Console.Write("{0} / {1} - {2} = ", num1, num2, num3);
                    Console.Write(num1 / num2 - num3);
                }
                else if (op1 == '/' && op2 == '*')
                {
                    Console.Write("{0} / {1} * {2} = ", num1, num2, num3);
                    Console.Write(num1 / num2 * num3);
                }
                else if (op1 != '+' || op1 != '-'|| op1 !='*'|| op1 != '/')
                {
                    Console.WriteLine("Invalid operator. Use +, -, * or /");
                }

                Console.WriteLine("\nDo you want to start over the program? Press y if not press n");
                
                restart = Console.ReadKey().KeyChar;

                if (restart == 'n')
                {
                    Environment.Exit(0);
                }



                Console.ReadLine();

            }
        }

    }
}
