using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
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
                    double e = (Math.Pow((x), z)) / (getFactorial(z));
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
