using System;

namespace EmployeeData
{
    class EmployeeData
    {
        public static void Main()
        {
            //Console.Write("Enter first name: ");
            string firstName = "Amanda";
            //Console.Write("Enter last name: ");
            string lastName = "Jonson";
            //Console.Write("Enter age: ");
            byte age = 27;
            //Console.Write("Enter gender: ");
            char gender = 'f';
            //Console.Write("Enter personal ID: ");
            ulong egn = 8306112507U;
            //Console.Write("Enter Unique Employee number: ");
            int emplNum = 27563571;

            //Console.WriteLine($"First name: {firstName}\nLast name: {lastName}");
            //Console.WriteLine($"Age: {age}\nGender: {gender}\nPersonal ID: {egn}");
            //Console.WriteLine($"Unique Employee number: {emplNum}");

            Console.WriteLine("First name: {0}\nLast name: {1}", firstName, lastName);
            Console.WriteLine("Age: {0}\nGender: {1}\nPersonal ID: {2}", age, gender, egn);
            Console.WriteLine("Unique Employee number: {0}", emplNum);
        }
    }
}
