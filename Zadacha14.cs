using System;

namespace Zadacha14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double sum = 0;
                while (true)
                {
                    Console.WriteLine("Введите число, если хотите остановить сложение введите stop");
                    string value = Console.ReadLine();
                    if (value == "stop")
                    {
                        break;
                    }
                    else
                    {
                        double number = Convert.ToDouble(value);
                        sum += number;
                    }
                }
                Console.WriteLine($"Сумма чисел = {sum}");
            }
            catch
            {
                Console.WriteLine("Введено не число и не stop программа завершена");
            }
        }
    }
}
