using System;

namespace Gitwork
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;

            Console.WriteLine("Enter a value for a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Substracting {a} - {b} equals {SubstractNumbers(a, b)}");

        }

        public static double SubstractNumbers (double a, double b)
        {
            return a - b;
        }
    }
}
