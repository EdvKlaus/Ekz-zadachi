using System;
using Stude;

namespace Stude
{
    class student
    {
        public string FIO;
        public string NumderGrooup;
        private int Age;

        public student(string fIO, string numderGrooup, int age)
        {
            FIO = fIO;
            NumderGrooup = numderGrooup;
            Age = age;
        }
        public void student_Info()
        {
            Console.WriteLine($"ФИО: {FIO}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Номер группы: {NumderGrooup}");
        }
    }
}
namespace Zadacha12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student[] students = { new student("Зюзин И.А.", "20ИТ17", 18),
                new student("Степанов И.Н.", "20ИТ17", 18),
                new student("Жабин О.А.", "20ИТ17", 18),
                new student("Горин З.Г", "20ИТ17", 18),
                new student("Мафин В.Л", "20ИТ17", 18) };
        }
    }
}
