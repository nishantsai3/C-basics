/*
5 Unique visitors
A website log records user IDs, with repeats. Use a HashSet to count how many distinct users
visited, and report how many log entries were repeats.

EXPECTED OUTPUT
Log entries: 8
Unique visitors: 5
Repeat entries: 3
*/

using System;
using System.Collections.Generic;

class Q5
{
    public static void Main(string[] args)
    {
        HashSet<int> users = new HashSet<int>();

        Console.Write("Enter number of log entries: ");
        int n = int.Parse(Console.ReadLine());

        int repeat = 0;

        Console.WriteLine("Enter user IDs:");

        for (int i = 0; i < n; i++)
        {
            int id = int.Parse(Console.ReadLine());
            if (users.Contains(id))
            {
                repeat++;
            }
            else
            {
                users.Add(id);
            }
        }

        Console.WriteLine("Log entries: " + n);
        Console.WriteLine("Unique visitors: " + users.Count);
        Console.WriteLine("Repeat entries: " + repeat);
    }
}