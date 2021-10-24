using System;
using System.Text.RegularExpressions;

namespace Sol_Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Deconstruct in C#");

            // Using Tuples
            TupleDemo demo = new();
            (string firstName, string lastName) = demo.GetName("Kishor Naik");
            Console.WriteLine($"{firstName} {lastName}");

            // Using User Defind type
            Student student = new("Kishor", "Naik");

            var (fName, lName) = student;
            Console.WriteLine($"{fName} {lName}");

            // Using Record
            Customer customer = new("Kishor", "Naik");
            var (f, n) = customer;
            Console.WriteLine($"{f} {n}");
        }
    }

    public class TupleDemo
    {
        // Using Tuples
        public (string firstName, string lastName) GetName(string fullName)
        {
            var splitName = Regex.Split(fullName, " ");

            return
                (
                    firstName: splitName[0],
                    lastName: splitName[1]
                );
        }
    }

    // Using User Define Type
    public class Student
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(out string fName, out string lName)
        {
            fName = this.FirstName;
            lName = this.LastName;
        }
    }

    // Using Record
    public record Customer(string f, string n);
}