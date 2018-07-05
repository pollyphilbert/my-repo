using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a;
            string s;
            s = Console.ReadLine();
            a = int.Parse(s);
            long f = 1;

            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Факториал равен:");
            Console.WriteLine(f);


        }
    }
}
