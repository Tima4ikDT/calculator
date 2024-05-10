using System;
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
            Func<double, double, double> division = (num1, num2) =>
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Невозможно разделить на ноль");
                }
                return num1 / num2;
            };

            // Использование
            double result = division(5, 3);
            Console.WriteLine(result);
        }
    }
}