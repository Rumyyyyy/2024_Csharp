﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class MainApp
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int plus(int, int)");
            return a + b;
        }
        public static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int plus(int, int)");
            return a + b + c;
        }
        public static double Plus(double a, double b)
        {
            Console.WriteLine("Calling int plus(double, double)");
            return a + b;
        }
        public static double Plus(int a, double b)
        {
            Console.WriteLine("Calling int plus(int, double)");
            return a + b;
        }
    }
}
