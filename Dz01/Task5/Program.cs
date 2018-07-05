using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int z;
            string s;
            s = Console.ReadLine();
            z = int.Parse(s);
            bool b = true;

            for (int i = 2; i < z; i++)
            {
                if (z % i == 0)
                {
                    b = false;
                }
            }
            Console.WriteLine("Результат: {0}", b);
        }
    }
}
