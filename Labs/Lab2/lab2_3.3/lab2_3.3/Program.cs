using System;

namespace lab2_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ім'я: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Привіт, " + name);
        }
    }
}
