﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> multiplication = (num1, num2) => num1 * num2;

            // Использование
            double result = multiplication(5, 3);
            Console.WriteLine(result);
        }
    }
}