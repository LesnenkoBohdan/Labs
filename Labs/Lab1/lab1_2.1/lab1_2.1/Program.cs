using System;

namespace lab1_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть прізвище: ");
            string lastname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Привіт " + lastname);
        }
    }
}
