using System;
using System.Globalization;

namespace lab2_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double gamma = 6.673 * Math.Pow(10, -11);
            Console.Write("Введіть масу1: ");
            double muss1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть масу2: ");
            double muss2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть відстань: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            var F = gamma*((muss1 * muss2) / Math.Pow(distance, 2));
            Console.WriteLine("F = " + F.ToString("e10", CultureInfo.InvariantCulture));
        }
    }
}
