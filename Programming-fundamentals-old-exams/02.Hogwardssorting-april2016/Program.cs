using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Hogwardssorting_april2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Home> homes = new List<Home>();
            string[] names = new string[4] { "Gryffindor", "Slytherin", "Ravenclaw", "Hufflepuff" };
            for (int i = 0; i < 4; i++)
            {
                Home home = new Home();
                home.Name = names[i];
                home.Students = new List<Student>();
                homes.Add(home);
            }
            
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                string name = Console.ReadLine();
                student.Name = name;
                long sum = 0;
                string facultyNumber = "";
                string facultyNumberEnding = "";
                foreach (var c in name)
                {
                    if (c != ' ')
                    {
                        sum += (int) c;
                    }

                    /*if (c >= 65 && c <= 90)
                    {
                        facultyNumberEnding += (char)c;
                    }*/
                }

                string[] namesArr = name.Split(' ');
                foreach (var item in namesArr)
                {
                    facultyNumberEnding += item[0];
                }

                facultyNumber = sum + facultyNumberEnding;
                student.FacultyNumber = facultyNumber;


                if (sum%4==0)
                {
                    Console.WriteLine($"{homes[0].Name} {student.FacultyNumber}");
                    homes[0].Students.Add(student);
                }
                else if (sum%4 == 1)
                {
                    Console.WriteLine($"{homes[1].Name} {student.FacultyNumber}");
                    homes[1].Students.Add(student);
                }
                else if (sum%4 == 2)
                {
                    Console.WriteLine($"{homes[2].Name} {student.FacultyNumber}");
                    homes[2].Students.Add(student);
                }
                else
                {
                    Console.WriteLine($"{homes[3].Name} {student.FacultyNumber}");
                    homes[3].Students.Add(student);
                }

            }
            Console.WriteLine();
            foreach (var home in homes)
            {
                Console.WriteLine($"{home.Name}: {home.Students.Count}");
            }
        }

        class Home
        {
            public string Name { get; set; } 
            public List<Student> Students { get; set; }
        }

        class Student
        {
            public string Name { get; set; }
            public string FacultyNumber { get; set; }
        }
    }
}
