using System;

namespace lab2_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Перший спосіб
            var mathExpression1 = 1.2 + 31;
            var mathExpression2 = 45 * 54 - 11;
            var mathExpression3 = 15.0 / 4;
            var mathExpression4 = 67 % 5;
            var mathExpression5 = (2 * 45.1 + 3.2) / 2;
            Console.WriteLine("Mathematical expression1 = " + mathExpression1);
            Console.WriteLine("Mathematical expression2 = " + mathExpression2);
            Console.WriteLine("Mathematical expression3 = " + mathExpression3);
            Console.WriteLine("Mathematical expression4 = " + mathExpression4);
            Console.WriteLine("Mathematical expression5 = " + mathExpression5);

            Console.WriteLine();

            //Другий спосіб  
            Console.WriteLine("Mathematical expression1 = " + (1.2 + 31));
            Console.WriteLine("Mathematical expression1 = " + (45 * 54 - 11));
            Console.WriteLine("Mathematical expression3 = " + (15.0 / 4));
            Console.WriteLine("Mathematical expression1 = " + (67 % 5));
            Console.WriteLine("Mathematical expression1 = " + ((2 * 45.1 + 3.2) / 2));


        }
    }
}
