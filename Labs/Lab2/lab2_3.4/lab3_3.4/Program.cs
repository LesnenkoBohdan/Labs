using System;


namespace lab2_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float numb1Float = (float)Math.Pow(10, -4);
            double numb1Double = (double)Math.Pow(10, -4);
            long numb1Long = (long)Math.Pow(10, -4);

            float numb2Float = (float)2.33E5;
            double numb2Double = (double)2.33E5;
            long numb2Long = (long)2.33E5;

            float numb3Float = (float)Math.PI;
            double numb3Double = (double)Math.PI;
            long numb3Long = (long)Math.PI;

            float numb4Float = (float)Math.E;
            double numb4Double = (double)Math.E;
            long numb4Long = (long)Math.E;

            float numb5Float = (float)Math.Sqrt(5);
            double numb5Double = (double)Math.Sqrt(5);
            long numb5Long = (long)Math.Sqrt(5);

            float numb6Float = (float)Math.Log10(100);
            double numb6Double = (double)Math.Log10(100);
            long numb6Long = (long)Math.Log10(100);

            Console.WriteLine("Float 10^-4 = " + numb1Float);
            Console.WriteLine("Double 10^-4 = " + numb1Double);
            Console.WriteLine("Long 10^-4 = " + numb1Long + "\n");

            Console.WriteLine("Float 2.33E5 = " + numb2Float);
            Console.WriteLine("Double 2.33E5 = " + numb2Double);
            Console.WriteLine("Long 2.33E5 = " + numb2Long + "\n");

            Console.WriteLine("Float π = " + numb3Float);
            Console.WriteLine("Double π = " + numb3Double);
            Console.WriteLine("Long π = " + numb3Long + "\n");

            Console.WriteLine("Float e = " + numb4Float);
            Console.WriteLine("Double e = " + numb4Double);
            Console.WriteLine("Long e = " + numb4Long + "\n");

            Console.WriteLine("Float √5 = " + numb5Float);
            Console.WriteLine("Double √5 = " + numb5Double);
            Console.WriteLine("Long √5 = " + numb5Long + "\n");

            Console.WriteLine("Float ln(100) = " + numb6Float);
            Console.WriteLine("Double ln(100) = " + numb6Double);
            Console.WriteLine("Long ln(100) = " + numb6Long);
        }
    }
}
