﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class9
    {
        static void Main8(string[] args)
        {
            //var vs dynamic variable

            //var keyword this will be used for declaring a variable and this will be a compile time variable
            //dynamic keyword will be a runtime variable

            var x = 1;
            //x = "Rajeshree";

            dynamic x1 = 2;
            x1 = "Rajeshree";

            Console.WriteLine(x);
            Console.WriteLine(x1);
        }
    }
}
