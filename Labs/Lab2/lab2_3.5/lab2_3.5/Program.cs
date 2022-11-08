using System;


namespace lab2_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ent 1 int numb: ");
            int numbInt1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ent 2 int numb: ");
            int numbInt2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ent 3 int numb: ");
            int numbInt3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ent 4 int numb: ");
            int numbInt4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ent 5 int numb: ");
            int numbInt5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ent 1 float numb: ");
            float numbFloat1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Ent 2 float numb: ");
            float numbFloat2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Ent 3 float numb: ");
            float numbFloat3 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Ent 4 float numb: ");
            float numbFloat4 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Ent 5 float numb: ");
            float numbFloat5 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x | " + numbInt1 + " | | " + numbInt2 + " | | " + numbInt3 + " | | " + numbInt4 + " | | " + numbInt5 + " |");
            Console.WriteLine("- | -- | -- | -- | -- | -- | ");
            Console.WriteLine("x | " + numbFloat1 + " | | " + numbFloat2 + " | | " + numbFloat3 + " | | " + numbFloat4 + " | | " + numbFloat5 + " |");

        }
    }
}
