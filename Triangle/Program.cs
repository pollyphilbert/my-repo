using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны:");
            int p,z,v;
            string s;
            s = Console.ReadLine();
            p = int.Parse(s);

            Console.WriteLine("Введите длину второй стороны:");
            s = Console.ReadLine();
            z = int.Parse(s);

            Console.WriteLine("Введите длину третьей стороны:");
            s = Console.ReadLine();
            v = int.Parse(s);

            if ((p < z + v) && (z < p + v) && (v < p + z))
            {
                Console.WriteLine("true");
            }
            else
            {
              Console.WriteLine("false"); 
            }
        }
    }
}
