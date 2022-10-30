using System;

namespace lab2_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            long round = (long)x;
            double frac = x - round;
            long floor = (long)Math.Floor(x);
            long ceil = (long)Math.Ceiling(x);
            Console.WriteLine("x = " + x + "\t" + "round = " + round + "\t" + "frac = " + frac + "\t" + "floor = " + floor + "\t" + "ceil = " + ceil);
        }
    }
}
