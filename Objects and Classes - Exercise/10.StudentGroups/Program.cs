using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Town> towns = RegisterStudentsInTowns();
            List<Group> groups = MakeGroups(towns);

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

          PrintResults(groups);

        }

        private static void PrintResults(List<Group> groups)
        {
           
            foreach (var group in groups.OrderBy(x=>x.Town.Name))
            {
                Console.Write($"{group.Town.Name} => ");
                List<string> emails = new List<string>();
                for (int i = 0; i < group.Students.Count; i++)
                {
                    emails.Add(group.Students[i].Email);
                }

                Console.WriteLine($"{string.Join(", ", emails)}");
            }
        }

        private static List<Group> MakeGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            foreach (var town in towns)
            {
                var student = town.Students.OrderBy(s => s.RegistrationDate)
                                            .ThenBy(s => s.Name)
                                            .ThenBy(s => s.Email)
                                            .ToList();
                
                while (student.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = student.Take(town.Seats).ToList();
                    student = student.Skip(town.Seats).ToList();
                    groups.Add(group);
                } 
            }
            return groups;
        }

        private static List<Town> RegisterStudentsInTowns()
        {
            List<Town> towns = new List<Town>();
            string command = Console.ReadLine();
            while (!command.Equals("End"))
            {
                string[] registrationsArr = command.Trim().Split('|');

                if (registrationsArr.Length == 1)
                {
                    Town town = new Town();
                    string[] townData = registrationsArr[0].Trim().Split(new char[] { '=', '>' },
                        StringSplitOptions.RemoveEmptyEntries);

                    town.Name = townData[0].Trim();
                    string[] seatsArr = townData[1].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    town.Seats = int.Parse(seatsArr[0]);
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    Student student = new Student()
                    {
                        Name = registrationsArr[0].Trim(),
                        Email = registrationsArr[1].Trim(),
                        RegistrationDate = DateTime.ParseExact(registrationsArr[2].Trim(), "d-MMM-yyyy",
                                                            CultureInfo.InvariantCulture)
                    };
                    towns[towns.Count - 1].Students.Add(student);
                }


                command = Console.ReadLine();
            }

            return towns;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
        public string Name { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
