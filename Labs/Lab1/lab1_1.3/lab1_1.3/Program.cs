/* 1.3. Скомпiлюйте програму з javac i запустiть її за допомогою java. Якщо
ви використовуєте iнше середовище розробки, нiж JDK, дiзнайтеся, як
компiлювати та запускати програми в цьому середовищi. */

using System;

namespace lab1_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press F to respect Victor Borodin: ");
            string f = Convert.ToString(Console.ReadLine());
            if (f == "f" ^ f == "F")
            {
                 Console.WriteLine("+ Respect to Victor Borodin !");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
