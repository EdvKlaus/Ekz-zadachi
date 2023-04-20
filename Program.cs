using System;
using System.Numerics;

namespace Zadacha23
{
    internal class Program
    {
        delegate void calcul(double a1, double b1, double a2, double b2);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите реальные части комплексного числа a");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите реальные части комплексного числа b");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());

            void Plus(double A1, double B1, double A2, double B2)
            {
                double result1 = A1 + A2;
                double result2 = B1 + B2;
                Console.WriteLine($"A + B = {result1} + {result2}i");
            }
            void Minus(double A1, double B1, double A2, double B2)
            {
                double result1 = A1 - A2;
                double result2 = B1 - B2;
                Console.WriteLine($"A - B = {result1} + {result2}i");
            }
            void Ymnogit(double A1, double B1, double A2, double B2)
            {
                double result1 = A1 * A2 - B1 * B2;
                double result2 = A1 * B2 - A2 * B1;
                Console.WriteLine($"A * B = {result1} + {result2}i");
            }

            calcul calculation = new calcul(Plus);
            calculation += Minus;
            calculation += Ymnogit;

            calculation(a1, b1, a2, b2);
        }
    }
}
