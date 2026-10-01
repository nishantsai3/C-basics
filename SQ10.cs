/*
10 Student records
Create a Student class with Name and Marks, override ToString, and hold five students in a List.
Print every student, then the topper, then the class average. Find the topper with a loop.

EXPECTED OUTPUT
Amit: 78
Priya: 92
Rahul: 65
Meera: 88
Kiran: 71
Topper: Priya (92)
Class average: 78.80
*/

using System;
class Student
{
    public string Name;
    public int Marks;

    public Student(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }

    public override string ToString()
    {
        return Name + ": " + Marks;
    }
}

class SQ10
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter marks: ");
            int marks = int.Parse(Console.ReadLine());

            students.Add(new Student(name, marks));
        }

        // Print all students
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        // Find topper
        Student top = students[0];

        foreach (Student student in students)
        {
            if (student.Marks > top.Marks)
            {
                top = student;
            }
        }

        // Calculate average
        int tot = 0;

        foreach (Student student in students)
        {
            tot += student.Marks;
        }

        double avg = (double)tot / students.Count;

        Console.WriteLine("Topper: " + top.Name + " (" + top.Marks + ")");
        Console.WriteLine("Class average: " + avg.ToString("F2"));
    }
}