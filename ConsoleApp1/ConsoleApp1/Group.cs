using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Group
    {
        public Student[] students;
        public int Groupno { get; set; }

        public Group()
        {
            students = new Student[0];
        }

        public Student[] GetStudents()
        {
            return students;
        } 

        public void Addstudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }
}
