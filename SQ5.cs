/*
5 Student marks grid
Use a 2-D array to hold marks for 3 students across 4 subjects. Print each student's total, then
the class average for each subject.

EXPECTED OUTPUT
Student 1 total: 310
Student 2 total: 286
Student 3 total: 334
Subject averages: 84.00 75.00 78.33 72.67
*/

using System;
class SQ5
{
    public static void Main(string[] args)
    {
        int[,] marks = new int[3, 4];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter marks for Student " + (i + 1));

            for (int j = 0; j < 4; j++)
            {
                marks[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++)
        {
            int tot = 0;

            for (int j = 0; j < 4; j++)
            {
                tot += marks[i, j];
            }

            Console.WriteLine("Student " + (i + 1) + " total: " + tot);
        }
        Console.Write("Subject averages: ");
        for (int j = 0; j < 4; j++)
        {
            int tot = 0;

            for (int i = 0; i < 3; i++)
            {
                tot += marks[i, j];
            }
            double avg = (double)tot / 3;
            Console.Write(avg.ToString("F2") + " ");
        }
    }
}