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
            Func<double, double> cosine = angleDegrees =>
            {
                double angleRadians = angleDegrees * Math.PI / 180;
                return Math.Cos(angleRadians);
            };

            // Использование
            double result = cosine(60);
            Console.WriteLine(result);
        }
    }
}