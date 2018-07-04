using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1:");
            string s,z;
            s = Console.ReadLine();
            int number1 ;
            number1 = int.Parse(s);

            Console.WriteLine("Введите знак:");           
            z = Console.ReadLine();

            Console.WriteLine("Введите число 2 :");           
            s = Console.ReadLine();
            int number2 ;
            number2 = int.Parse(s);
            float rez = 0;
            Console.WriteLine(z);  
            if (z == "+")
            {
                rez = number1 + number2;
            }
            else if (z == "-")
            {
                rez = number1 - number2;   
                Console.WriteLine("Результат:");
                Console.WriteLine(rez);
            }
            else if (z == "*")
            {
                rez = number1 * number2;
                Console.WriteLine("Результат:");
                Console.WriteLine(rez);
            }
            else if (z == "/")
            {
                if (number2 != 0)
                {
                    rez = number1 / number2;
                    Console.WriteLine("Результат:");
                    Console.WriteLine(rez);
                }
                else
                {
                    Console.WriteLine("На 0 делить нельзя");
                }
            }
            else if (z == "%")
            {
                rez = number1 % number2;
                Console.WriteLine("Результат:");
                Console.WriteLine(rez);
            }
            else
            {
                Console.WriteLine("Не коректный знак");
            }
        
        }
    }
}
