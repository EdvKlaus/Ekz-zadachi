using System;


namespace Zadacha10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());

            double D = (Math.Pow(b, 2) - 4 * a * c);
            if(D == 0)
            {
                double x1 = (-1 * b) / (2 * a);
                Console.WriteLine($"Корень уравнения равен {x1}");
            }
            if(D > 0)
            {
                double x1 = ((-1 * b) + Math.Sqrt(D)) / (2 * a);
                double x2 = ((-1 * b) - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Первый корень уравнения равен {x1}");
                Console.WriteLine($"Второй корень уравнения равен {x2}");
            }
            else if(0 > D)
            {
                Console.WriteLine("Дествительных корней нет");
            }
        }
    }
}
