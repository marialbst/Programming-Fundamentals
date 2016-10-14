using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();

        public double FindAverageGrade()
        {
            double averageGrade = this.Grades.Average();
            return averageGrade;
        }
    }
}
