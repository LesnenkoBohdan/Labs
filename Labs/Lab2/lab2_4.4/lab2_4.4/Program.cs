using System;


namespace lab2_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ent side1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ent side2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ent side3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            double perim = side1 + side2 + side3;
            Console.WriteLine(perim);
        }
    }
}
