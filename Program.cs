using System;

namespace Zadacha22
{
    internal class Program
    {
        delegate void calcul(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чисто a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чисто b");
            int b = Convert.ToInt32(Console.ReadLine());

            void Plus(int A, int B)
            {
                int result = A + B;
                Console.WriteLine($"A + B = {result}");
            }
            void Minus(int A, int B)
            {
                int result = A - B;
                Console.WriteLine($"A - B = {result}");
            }
            void Ymnogit(int A, int B)
            {
                int result = A * B;
                Console.WriteLine($"A * B = {result}");
            }

            calcul calculation = new calcul(Plus);
            calculation += Minus;
            calculation += Ymnogit;

            calculation(a , b);
        }
    }
}
