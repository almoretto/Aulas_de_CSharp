using System.Collections.Generic;
using System;
using System.Linq;

namespace Aula15ExercicioSetProp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> studentsInClassA = new HashSet<int>();
            HashSet<int> studentsInClassB = new HashSet<int>();
            HashSet<int> studentsInClassC = new HashSet<int>();
            HashSet<int> studentsInClass = new HashSet<int>();
            Console.Write("Enter Number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Console.Write("Enter the Class: ");
            char studentClass = char.Parse(Console.ReadLine().ToUpper());
            studentsInClassA = (AddStudent(numberOfStudents, studentClass));
            Console.Write("Enter Number of students: ");
            numberOfStudents = int.Parse(Console.ReadLine());
            Console.Write("Enter the Class: ");
            studentClass = char.Parse(Console.ReadLine().ToUpper());
            studentsInClassB = (AddStudent(numberOfStudents, studentClass));
            Console.Write("Enter Number of students: ");
            numberOfStudents = int.Parse(Console.ReadLine());
            Console.Write("Enter the Class: ");
            studentClass = char.Parse(Console.ReadLine().ToUpper());
            studentsInClassC = (AddStudent(numberOfStudents, studentClass));
            studentsInClass = studentsInClassA;
            studentsInClass.UnionWith(studentsInClassB);
            studentsInClass.UnionWith(studentsInClassC);

            Console.WriteLine("students: "+studentsInClass.Count);


        }
        static HashSet<int> AddStudent(int number, char studentClass)
        {
            HashSet<int> students = new HashSet<int>();

            Console.WriteLine("Enter the students code for class: " + studentClass);
            for (int i = 0; i < number; i++)
            {
                students.Add(int.Parse(Console.ReadLine()));
            }
            return students;
        }
    }
}
