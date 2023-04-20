using System;

namespace Zadacha8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Проверка на целостность
            if (n % 1 == 0)
            {
                if ((n % 2) == 0)
                {
                    Console.WriteLine($"Число: {n} чётное");
                }
                else if ((n % 2) != 0)
                {
                    Console.WriteLine($"Число: {n} нечётное");
                }
            }
            else
            {
                Console.WriteLine($"Число: {n} должно быть целым");
            }
        }
    }
}
