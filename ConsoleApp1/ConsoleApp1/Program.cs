using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname");
            string surname = Console.ReadLine();
            int age;
            int experience;
            do
            {
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age < 0);
            do
            {
                Console.WriteLine("Enter experience");
                experience = Convert.ToInt32(Console.ReadLine());

            } while (experience < 0 || experience > 80);

            Teacher teacher = new Teacher(name, surname, age, experience);
            Console.WriteLine(teacher.ToString());
            Console.WriteLine(teacher.Experience);
            
            Console.WriteLine("\n");
            Console.WriteLine("Student");
            Console.WriteLine("Enter name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter surname");
            string surname1 = Console.ReadLine();
            int age1;
            
            do
            {
                Console.WriteLine("Enter age");
                age1 = Convert.ToInt32(Console.ReadLine());

            } while (age1 < 0);

            Student student = new Student(name1, surname1, age1);

            Group group = new Group();
            group.Addstudent(student);
            foreach (Student item in group.students)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
