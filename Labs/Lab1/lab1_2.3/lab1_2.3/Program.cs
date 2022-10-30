using System;
using System.Globalization;

namespace lab1_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ent a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ent b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double GeomMean = Math.Sqrt(a * b);
            Console.WriteLine("Десяткове представлення: " + GeomMean);
            Console.WriteLine("Наукове представлення: " + GeomMean.ToString("e10", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
