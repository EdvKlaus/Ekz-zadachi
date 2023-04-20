using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[3] {a, b, c };
            Array.Sort(array);
            a = array[0];
            b = array[1];
            c = array[2];

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

        }
    }
}
