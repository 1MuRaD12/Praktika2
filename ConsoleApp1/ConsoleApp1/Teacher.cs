using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Teacher : Person
    {
        public int Id { get; }

        public static int Count;

        private int _experience;

        public Teacher(string name, string surname, int age, int experience) :base(name,surname,age)
        {
            Count++;
            Id = Count;
            Experience = experience;
        }

        public int Experience
        {
            get => _experience;
            set
            {
                if(value >0 && value < 80)
                {
                    _experience = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name:{Name}\nSurname:{Surname}\nAge:{Age}\nId:{Id}";
        }
    }
}
