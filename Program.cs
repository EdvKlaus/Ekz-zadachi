using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_16
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 1) {
                Console.WriteLine($"Факториал числа {x} = {Factorial(x)}");
            }
            else if(x < 1)
            {
                Console.WriteLine("Значение меньше 1");
            }
        }

        public static int Factorial(int x)
        { 
            if (x == 1) return 1;
            return Factorial(x - 1) * x;
        }
    }
}
