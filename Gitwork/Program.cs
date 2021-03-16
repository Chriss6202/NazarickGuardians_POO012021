using System;

namespace Gitwork
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;

            Console.Write("Enter a value for a:");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter a value for b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication {a} * {b} equals {MultNumbers(a, b)}");

        }

        public static double MultNumbers (double a, double b)
        {
            return a * b;
        }
    }
}
