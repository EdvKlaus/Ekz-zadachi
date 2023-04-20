using System;

namespace Zadacha7
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
                for (var j = 1; j <= n; j++)
                {
                    double z = 2 * j + 1;
                    double y = 2 * n;
                    double e = (Math.Pow((x), z)) / (getFactorial(y));
                    S = S + e;
                }
                Console.WriteLine($"Ответ: {S}");
            }
        }
        //Считает факториал
        public static int getFactorial(double f)
        {
            int result = 1;
            for (int i = 1; i <= f; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
