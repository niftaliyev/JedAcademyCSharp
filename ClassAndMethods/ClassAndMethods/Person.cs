using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    public class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public void InitializeName(string name)
        {
            Console.WriteLine("test");
            this.Name = name;
        }
        public void InitializeSurname(string surname)
        {
            this.Surname = surname;
        }
        public void InitializeAge(int age)
        {
            this.Age = age;
        }

        public void PrintTest()
        {
            Console.WriteLine("Test in person class");
        }

    }

}
