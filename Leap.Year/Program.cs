using System;

namespace Leap.Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int z,r;
            string s;
            s = Console.ReadLine();
            z= int.Parse(s);
            r = z%4;
            if (r == 0)
            {
                Console.WriteLine("Год высокосный");
            }
            else 
            {
                Console.WriteLine("Год не высокосный");
            }


        }
    }
}
