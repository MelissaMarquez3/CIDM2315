using System;
using System.Collections.Generic;

namespace Homework6
{
    // Create a Student class
     class Student
    {
        private int studentID;
        private string studentName;

        // Create a static list to keep track of students
        public string getStudentName(){
            return studentName;
        }
        public static List<Student> studentList = new List<Student>();

        // Constructor to initialize student ID and name
        public Student(int studentID, string studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            studentList.Add(this);
        }

        // Print student information
        public void PrintInfo()
        {
            Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create student objects
            int student1ID = 111;
            string student1Name = "Alice";
            int student2ID = 222;
            string student2Name = "Bob";
            int student3ID = 333;
            string student3Name = "Cathy";
            int student4ID = 444;
            string student4Name = "David";

            Student student1 = new Student(student1ID, student1Name);
            Student student2 = new Student(student2ID, student2Name);
            Student student3 = new Student(student3ID, student3Name);
            Student student4 = new Student(student4ID, student4Name);

            // Create a dictionary to store gradebook information
            Dictionary<string, double> gradebook = new Dictionary<string, double>();
            string name1 = "Alice";
            double gpa1 = 4.0;
            string name2 = "Bob";
            double gpa2 = 3.6;
            string name3 = "Cathy";
            double gpa3 = 2.5;
            string name4 = "David";
            double gpa4 = 1.8;

            gradebook.Add(name1, gpa1);
            gradebook.Add(name2, gpa2);
            gradebook.Add(name3, gpa3);
            gradebook.Add(name4, gpa4);

            string newStudentName = "Tom";
            double newStudentGPA = 3.3;

            if (!gradebook.ContainsKey(newStudentName))
            {
                gradebook.Add(newStudentName, newStudentGPA);
            }

            double totalGPA = 0;

            // Calculate the total GPA
            foreach (double gpa in gradebook.Values)
            {
                totalGPA += gpa;
            }

            double averageGPA = totalGPA / gradebook.Count;
            Console.WriteLine("The average GPA is: " + averageGPA);
            Console.WriteLine("Students with GPA greater than the average GPA:");

            // Print student information for students with GPA greater than the average GPA
            foreach (Student student in Student.studentList)
            {
                if (gradebook.ContainsKey(student.getStudentName()) && gradebook[student.getStudentName()]>averageGPA)
                {
                    student.PrintInfo();
                }
            }
        }
    }
}

    
    

