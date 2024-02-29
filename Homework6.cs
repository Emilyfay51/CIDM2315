namespace Homework6;
using System;


class Program
{
    static void Main(string[] args)
    {
        // Create Professor 1 object
        Professor p1 = new Professor();
        p1.ProfName = "Alice";
        p1.ClassTeach = "Java";
        p1.Salary = 9000;
        p1.PrintInfo();

        // Create Professor 2 object
        Professor p2 = new Professor();
        p2.ProfName = "Bob";
        p2.ClassTeach = "Math";
        p2.Salary = 8000;
        p2.PrintInfo();

        // Create Student 1 object
        Student s1 = new Student();
        s1.StudentName = "Lisa";
        s1.ClassEnroll = "Java";
        s1.Grade = 90;
        s1.PrintInfo();

        // Create Student 2 object
        Student s2 = new Student();
        s2.StudentName = "Tom";
        s2.ClassEnroll = "Math";
        s2.Grade = 80;
        s2.PrintInfo();

        // Calculate the difference in salary between the two professors
        double salaryDifference = p1.Salary - p2.Salary;
        Console.WriteLine($"The salary difference between {p1.ProfName} and {p2.ProfName} is: {salaryDifference}");

        // Calculate the total grade of Lisa’s grade and Tom’s grade
        double totalGrade = s1.Grade + s2.Grade;
        Console.WriteLine($"The total grade of {s1.StudentName} and {s2.StudentName} is: {totalGrade}");
    }
}

class Professor
{
    public string ProfName;
    public string ClassTeach;
    public double Salary;

    public void PrintInfo()
    {
        Console.WriteLine($"Professor {ProfName} teaches {ClassTeach}, and the salary is: {Salary}");
    }
}

class Student
{
    public string StudentName;
    public string ClassEnroll;
    public double Grade;

    public void PrintInfo()
    {
        Console.WriteLine($"Student {StudentName} enrolls in {ClassEnroll}, and the grade is: {Grade}");
    }
}


        


