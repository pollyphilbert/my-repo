using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n;
            string s;
            s = Console.ReadLine();
            n = int.Parse(s);
            long r = 0;

            for (int i = 1; i <= n; i++)
            {
              r += i;  
            }
            Console.WriteLine("Ваш результат:");
            Console.WriteLine(r);

        }
    }
}
