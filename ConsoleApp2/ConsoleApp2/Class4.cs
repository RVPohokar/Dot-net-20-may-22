﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class4
    {
        static void Main3(string[] args)
        {


            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < 5; col++)
            //    {
            //        Console.WriteLine("row: "+row+ "col: "+col);
            //    }
            //}

            for (int row = 0; row <= 9; row++)
            {
                for (int col = 0; col <= 9; col++)
                {
                    if (row == 0 || col == 0 || row == 9 || col == 9 || row == col || col == 9 - row + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
