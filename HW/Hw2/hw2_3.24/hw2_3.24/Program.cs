using System;
/*Lab1_2 Task 3_24*/
namespace hw2_3._24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && b + c > a && c + a > b)
            {
                double eng1 = Math.Acos(((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2))) / (2 * b * c));
                double eng2 = Math.Acos(((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2))) / (2 * a * c));
                double eng3 = Math.Acos(((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2))) / (2 * a * b));

                Console.WriteLine("1 кут = " + (180 * eng1) / Math.PI);
                Console.WriteLine("2 кут = " + (180 * eng2) / Math.PI);
                Console.WriteLine("3 кут = " + (180 * eng3) / Math.PI);
            }
            else
            {
                Console.WriteLine("Не правильно введені сторони !");
            }
            Console.ReadLine();
        }
    }
}
