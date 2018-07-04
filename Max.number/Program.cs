using System;

namespace Max.number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a,b,c;
            string s;
            s = Console.ReadLine();
            a = int.Parse(s);

            Console.WriteLine("Введите второе число:");
            s = Console.ReadLine();
            b = int.Parse(s);

            Console.WriteLine("Введите третее число:");
            s = Console.ReadLine();
            c = int.Parse(s);

            if ((a > b) && (a > c))
            {
                Console.WriteLine(a);
            }
            else if ((b > a) && (b >c))
            {
                Console.WriteLine(b);
            }
            else if ((c > a) && (c > b))
            {
                Console.WriteLine(c);
            }
            else if((a == b) && (b == c))
            {
                Console.WriteLine("Все числа равны");
            }
        }
        
    }
}
