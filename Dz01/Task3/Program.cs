using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string s;
            s = Console.ReadLine();
            int l;
            l = s.Length;
            int a;
            int r = 0;
            
            for (int i = 0; i < l; i++)
            {
                a = (int)Char.GetNumericValue(s[i]);
                r = r + a;
            }
            Console.WriteLine("Сумма цифр:");
            Console.WriteLine(r);
        }
    }
}
