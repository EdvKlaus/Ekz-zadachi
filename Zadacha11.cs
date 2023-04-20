using System;

namespace Zadacha11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(5, 155);

            if (number <= 100 && number >= 25)
            {
                Console.WriteLine($"Число {number} входит в деопозон от 25 до 100");
            }
            else
            {
                Console.WriteLine($"Число {number} не входит в деопозон от 25 до 100");
            }
        }
    }
}
