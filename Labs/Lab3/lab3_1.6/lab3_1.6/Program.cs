using System;

namespace lab3_1._6
{

    class Program
    {
        class Dog
        {
            public string name;
            public string say;
        }

        static void Main(string[] args)
        {
            Dog firstdog = new Dog();
            firstdog.name = "spot";
            firstdog.say = "Ruff!";

            Dog seconddog = new Dog();
            seconddog.name = "scruffy";
            seconddog.say = "Wurf!";

            Console.WriteLine($"Name of dog: {firstdog.name} \nThis dog says: {firstdog.say}");
            Console.WriteLine();
            Console.WriteLine($"Name of dog: {seconddog.name} \nThis dog says: {seconddog.say}");
        }
    }
}  