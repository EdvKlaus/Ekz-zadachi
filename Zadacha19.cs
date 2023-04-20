using System;


namespace Zadacha19
{
    class Person
    {
        public Person(string name, int age = 18)
        {
            Name = name;
            if (age >= 0 && age <= 100)
            {
                Age = age;
            }
        }
        public string Name;
        private int Age;

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}. Возраст: {Age}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Person person = new Person("Ivan", 500);
            person.Print();
        }
    }
}
