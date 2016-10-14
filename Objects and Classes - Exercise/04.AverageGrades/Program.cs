using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                students[i] = ReadStudent();
            }

            foreach (var student in students.Where(gr => gr.AverageGrade >= 5)
                                            .OrderBy(st => st.Name)
                                            .ThenByDescending(st => st.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
    
    }

        public static Student ReadStudent()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Student student = new Student();
            student.Name = input[0];
            List<double> gradesDoubles = new List<double>();
            for (int i = 1; i < input.Length; i++)
            {
                double grade = double.Parse(input[i]);
                gradesDoubles.Add(grade);
            }

            student.Grades = gradesDoubles;
            return student;
        }
    }

    /*public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();

        public double FindAverageGrade()
        {
            double averageGrade = this.Grades.Average();
            return averageGrade;
        }
    }*/
}
