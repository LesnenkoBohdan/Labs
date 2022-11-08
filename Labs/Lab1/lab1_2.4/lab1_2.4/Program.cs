using System;


namespace lab1_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ent C°: ");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = 9 * Celsius / 5 + 32;
            Console.WriteLine("F = " + Fahrenheit);
        }
    }
}
