using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        private int _age;

        public string[] Lessons;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
    }
}
