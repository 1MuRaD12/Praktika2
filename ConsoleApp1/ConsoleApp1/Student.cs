using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student:Person
    {
        public int Id { get; }

        public static int Count;

        public Student(string name, string surname, int age):base(name, surname, age)
        {
            Count++;
            Id = Count;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nSurname:{Surname}\nAge:{Age}\nId:{Id}";
        }
    }
}
