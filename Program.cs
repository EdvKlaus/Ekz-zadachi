using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha24
{
    struct Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }

        public Student(string name, string surname, int group)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
        }

    }

    class Program
    {
        static void Main()
        {
            Student[] students = new Student[3] { new Student("Дмитрий", "Лесов", 202013),
                new Student("Димитрий", "Ласов", 202015),
                new Student("Димутрий", "Ласеков", 202017) };
        }
    }
}
