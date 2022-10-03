/* 1.1. Створiть клас, що мiстить неiнiцiалiзованi поля типiв int, char та ря-
док, i надрукуйте їх значення, щоб пе еконатися, що Java виконує
iнiцiалiзацi  за замовчуванням. */

using System;

namespace lab1_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть int");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine("Введіть string");
            string b = Console.ReadLine();
            Console.WriteLine(b);
            Console.WriteLine("Введіть char");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c);
        }
    }
}
    