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
            Func<double, double, double> exponentiation = (num, exponent) => Math.Pow(num, exponent);

            // Использование
            double result = exponentiation(2, 3);
            Console.WriteLine(result);
        }
    }
}