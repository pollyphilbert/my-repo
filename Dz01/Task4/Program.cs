using System;

namespace Task4
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

            int i = 1;
            while (i * i < a)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}",i, i*i);
                i++;
            }

        }
    }
}
