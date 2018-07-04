using System;

namespace Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оцунку:");
            int a;
            string s;
            s = Console.ReadLine();
            a = int.Parse(s);

            if (a >=90)
            {
                Console.WriteLine("Результат: A");   
            }
            else if (a >= 75)
            {
                Console.WriteLine("Результат: B");   
            }
            else if (a >= 65)
            {
                Console.WriteLine("Результат: C");
            }
            else if (a >= 60)
            {
                Console.WriteLine("Результат: D");
            }
            else if (a < 60)
            {
                Console.WriteLine("Результат: E");
            }
        }
    }
}