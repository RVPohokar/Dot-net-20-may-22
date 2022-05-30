using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Calculator1
    {
        public int Number1, Number2;

        public Calculator1(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        public void Print()
        {
            Console.WriteLine("Number 1=" + Number1);
            Console.WriteLine("Number 2=" + Number2);
        }

        public static Calculator1 operator *(Calculator1 c1, Calculator1 c2)
        {
            Calculator1 c3 = new Calculator1(0, 0);
            c3.Number1 = c1.Number1 * c2.Number1;
            c3.Number2 = c1.Number2 * c2.Number2;
            return c3;
            }
    class Class3
    {
            public static void Main4()
            {
                Calculator1 calculator1 = new Calculator1(15, 20);
                Calculator1 calculator2 = new Calculator1(20, 20);
                Calculator1 calculator3 = new Calculator1(0, 0);
                calculator3 = calculator1 * calculator2;
                calculator3.Print();
            }
        }
    }
}
