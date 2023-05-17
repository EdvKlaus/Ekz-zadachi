using System;

namespace Zadacha_16
{
    class FactorialException : ArgumentException
    {
        public FactorialException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Введите число");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x < 1)
                {
                    throw new FactorialException("Вы ввели значение меньше 1");
                }
                Console.WriteLine($"Факториал числа {x} = {Factorial(x)}");
            }
            catch (FactorialException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public static int Factorial(int x)
        { 
            if (x == 1) return 1;
            return Factorial(x - 1) * x;
        }
    }
}
