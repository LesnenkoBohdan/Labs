using System;


namespace lab1_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ent arg1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);

            Console.Write("Ent arg2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);

            Console.Write("Ent arg3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c);

            int sum = a + b + c;

            Console.WriteLine("Your sum is: " + sum);

            Console.ReadLine();
        }
    }
}
