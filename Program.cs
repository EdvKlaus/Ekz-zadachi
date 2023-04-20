using System;

namespace Zadacha9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B = Convert.ToDouble(Console.ReadLine());

            double a = Math.Abs(A - 10);
            double b = Math.Abs(B - 10);

            if(a < b)
            {
                Console.WriteLine($"Число: {A} ближе к 10 чем число {B}");
            }
            else if(a > b){
                Console.WriteLine($"Число: {B} ближе к 10 чем число {A}");
            }
        }
    }
}
