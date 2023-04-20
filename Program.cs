using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha20
{
    class Person
    {
        public string fullName;
        public int age;

        public Person()
        {

        }
        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person();
            Person person2 = new Person("Егоров Д.Н.", 22);
        }
    }

}
