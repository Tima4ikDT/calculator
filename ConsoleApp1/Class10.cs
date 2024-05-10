using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> squareRoot = num =>
            {
                if (num < 0)
                {
                    throw new ArithmeticException("Квадратный корень из отрицательного числа не определен");
                }
                return Math.Sqrt(num);
            };

            // Использование
            double result = squareRoot(16);
            Console.WriteLine(result);
        }
    }
}