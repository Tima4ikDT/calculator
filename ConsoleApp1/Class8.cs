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
            Func<double, double> cotangent = angleDegrees =>
            {
                double angleRadians = angleDegrees * Math.PI / 180;
                return 1 / Math.Tan(angleRadians);
            };

            // Использование
            double result = cotangent(45);
            Console.WriteLine(result);
        }
    }
}