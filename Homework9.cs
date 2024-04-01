namespace Homework9;
 using System;

    class Student
    {
        private int studentID;
        public string studentName; // Change access level to public

        public static List<Student> studentList = new List<Student>();

        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create students
            Student student1 = new Student(111, "Alice");
            Student student2 = new Student(222, "Bob");
            Student student3 = new Student(333, "Cathy");
            Student student4 = new Student(444, "David");

            // Create a Dictionary to hold student names and GPAs
            Dictionary<string, double> gradebook = new Dictionary<string, double>();

            // Add name-grade pairs to the gradebook
            gradebook["Alice"] = 4.0;
            gradebook["Bob"] = 3.6;
            gradebook["Cathy"] = 2.5;
            gradebook["David"] = 1.8;

            // Check if "Tom" exists in gradebook, if not, insert with GPA 3.3
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }

            // Calculate the average GPA of all students
            double sum = 0;
            foreach (var student in gradebook.Values)
            {
                sum += student;
            }
            double averageGPA = sum / gradebook.Count;

            // Print out the average GPA
            Console.WriteLine($" The Average GPA is: {averageGPA}");

            // Print out information about students whose GPA is greater than the average GPA
            
            foreach (var entry in gradebook)
            {
                if (entry.Value > averageGPA)
                {
                    
                    foreach (var student in Student.studentList)
                    {
                        if (student.studentName == entry.Key)
                        {
                            student.PrintInfo();
                            break;
                        }
                    }
                }
            }
        }
    }

