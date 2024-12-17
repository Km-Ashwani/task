using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Student
    {
        // Static variable to keep track of register number
        private static int registerNumber = 1000;

        // Instance variable for student name
        public string Name { get; set; }

        // Instance variable for the generated register number
        public int RegisterNumber { get; private set; }

        // Static constructor to initialize the static register number
        static Student()
        {
            // The static constructor will be called once before any instance of Student is created
            Console.WriteLine("Static constructor called: Register numbers initialized.");
        }

        // Constructor to generate register number for each student
        public Student(string name)
        {
            Name = name;
            // Assign a unique register number
            RegisterNumber = registerNumber++;
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}, Register Number: {RegisterNumber}");
        }
    }

    public class Process
    {
        public void Print()
        {
            // Creating 100 student instances and generating their register numbers
            for (int i = 1; i <= 100; i++)
            {
                // Generating a student name (just for demonstration purposes)
                string studentName = "Student" + i;

                // Creating student object and generating the register number automatically
                Student student = new Student(studentName);

                // Displaying student information
                student.Display();
            }
        }
    }
}
