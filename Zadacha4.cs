using System;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 0;
            Console.WriteLine("Введите n ");
            double n = Convert.ToDouble(Console.ReadLine());
            // проверка отрицательности n
            if (n < 0)
            {
                Console.WriteLine("n должен быть положительным");
            }
            else
            {
                Console.WriteLine("Введите x");
                double x = Convert.ToDouble(Console.ReadLine());
                for (var j = 2; j <= n; j++)
                {
                    double e = (Math.Pow((x), j)) / j;
                    if ((j % 2) == 0)
                    {
                        S = S + e;
                    }
                    else if ((j % 2) != 0)
                    {
                        S = S - e;
                    }
                }
                Console.WriteLine($"Ответ: {S}");
            }
        }
    }
}
