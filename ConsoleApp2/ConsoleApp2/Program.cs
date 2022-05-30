using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main1(string[] args)
        {
            //switch case
            Console.WriteLine("Enter your choice ");
            string s = Console.ReadLine();
            Console.WriteLine("value Entered from user is : " + Convert.ToInt32(s));
            int choice = Convert.ToInt32(s);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("hi defualt case");
                    break;
            }
        }
    }
}
