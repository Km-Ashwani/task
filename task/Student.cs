using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Student1
    {
        // Instance variables for student information
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public int[] Marks { get; set; }
        public string[] Subjects { get; set; }

        // Constructor to initialize the student's data
        public Student1(string name, int rollNumber, string[] subjects, int[] marks)
        {
            Name = name;
            RollNumber = rollNumber;
            Subjects = subjects;
            Marks = marks;
        }
        public int CalculateTotal()
        {
            int total = 0;
            foreach (int mark in Marks)
            {
                total += mark;
            }
            return total;
        }
        // Method to calculate the percentage
        public double CalculatePercentage()
        {
            int totalMarks = 100 * Marks.Length; // Assuming each subject is out of 100
            double percentage = (double)CalculateTotal() / totalMarks * 100;
            return percentage;
        }

        // Method to determine the grade based on percentage
        public string CalculateGrade()
        {
            double percentage = CalculatePercentage();
            if (percentage >= 90)
                return "A+";
            else if (percentage >= 80)
                return "A";
            else if (percentage >= 70)
                return "B+";
            else if (percentage >= 60)
                return "B";
            else if (percentage >= 50)
                return "C";
            else
                return "F";
        }
        // Method to display the marksheet
        public void DisplayMarksheet()
        {
            Console.WriteLine("Marksheet:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine("Subjects and Marks:");

            for (int i = 0; i < Subjects.Length; i++)
            {
                Console.WriteLine($"{Subjects[i]}: {Marks[i]}");
            }

            int total = CalculateTotal();
            double percentage = CalculatePercentage();
            string grade = CalculateGrade();

            Console.WriteLine($"\nTotal Marks: {total}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
