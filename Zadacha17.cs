using System;

namespace Zadacha17
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void Print_Info()
        {
            Console.WriteLine($"Имя: {Name}. Возраст: {Age}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Person person1 = new Person(15, "Dima");
            Person person2 = new Person(22, "Ivan");
            Person person3 = new Person(30, "Vladimir");

            person1.Print_Info();
            person2.Print_Info();
            person3.Print_Info();
        }
    }
}
