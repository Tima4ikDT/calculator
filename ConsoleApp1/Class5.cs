using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> sine = angleDegrees =>
            {
                double angleRadians = angleDegrees * Math.PI / 180;
                return Math.Sin(angleRadians);
            };

            // Использование
            double result = sine(30);
            Console.WriteLine(result);
        }
    }
}
