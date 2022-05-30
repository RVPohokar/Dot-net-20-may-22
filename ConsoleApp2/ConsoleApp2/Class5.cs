using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class5
    {
        static void Main4(string[] args)
        {
            int operation = 1;
            int num1, num2, result;
            Console.Write("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    result = num1 + num2;

                    Console.WriteLine("addition is");

                    break;
                case 2:
                    Console.WriteLine("substraction is");
                    break;
                case 3:
                    Console.WriteLine("division is");
                    break;
                case 4:
                    Console.WriteLine("multiplication is");
                    break;
                default:
                    Console.WriteLine("Please enter value");
                    break;
            }
        }
    }

    }