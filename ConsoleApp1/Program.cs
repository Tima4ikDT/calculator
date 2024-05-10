using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp6.Class1;
using static ConsoleApp6.Class2;
using static ConsoleApp6.Class3;
using static ConsoleApp6.Class4;
using static ConsoleApp6.Class5;
using static ConsoleApp6.Class6;
using static ConsoleApp6.Class7;
using static ConsoleApp6.Class8;
using static ConsoleApp6.Class9;
using static ConsoleApp6.Class10;

namespace EngineeringCalculator
{
    class Program
    {
        static Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>()
        {
            { "1", Addition.Calculate },
            { "2", Subtraction.Calculate },
            { "3", Multiplication.Calculate },
            { "4", Division.Calculate },
        };

        static Dictionary<string, Func<double, double>> trigonometricOperations = new Dictionary<string, Func<double, double>>()
        {
            { "5", Sine.Calculate },
            { "6", Cosine.Calculate },
            { "7", Tangent.Calculate },
            { "8", Cotangent.Calculate },
        };

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                if (operations.TryGetValue(choice, out var operation))
                {
                    PerformOperation(operation);
                }
                else if (trigonometricOperations.TryGetValue(choice, out var trigOperation))
                {
                    PerformTrigonometricOperation(trigOperation, choice);
                }
                else if (choice == "9")
                {
                    PerformExponentiation();
                }
                else if (choice == "10")
                {
                    PerformSquareRoot();
                }
                else if (choice == "11")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Неверная операция. Попробуйте снова.");
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.WriteLine("5. Синус (sin)");
            Console.WriteLine("6. Косинус (cos)");
            Console.WriteLine("7. Тангенс (tan)");
            Console.WriteLine("8. Котангенс (cot)");
            Console.WriteLine("9. Возведение в степень (^)");
            Console.WriteLine("10. Квадратный корень (√)");
            Console.WriteLine("11. Выход");
        }

        static void PerformOperation(Func<double, double, double> operation)
        {
            double num1 = GetNumber("Введите первое число:");
            double num2 = GetNumber("Введите второе число:");
            Console.WriteLine($"Результат: {operation(num1, num2)}");
        }

        static void PerformTrigonometricOperation(Func<double, double> operation, string choice)
        {
            double angleDegrees = GetNumber("Введите угол в градусах:");
            string operationName = trigonometricOperations.FirstOrDefault(x => x.Key == choice).Value.Method.Name;
            Console.WriteLine($"Результат {operationName} угла {angleDegrees} градусов: {operation(angleDegrees)}");
        }

        static double GetNumber(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }

        static void PerformExponentiation()
        {
            double num = GetNumber("Введите число:");
            double exponent = GetNumber("Введите степень:");
            Console.WriteLine($"Результат: {Exponentiation.Calculate(num, exponent)}");
        }

        static void PerformSquareRoot()
        {
            double num = GetNumber("Введите число:");
            Console.WriteLine($"Результат квадратного корня из {num}: {SquareRoot.Calculate(num)}");
        }
    }

}







