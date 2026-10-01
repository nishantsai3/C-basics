/*
2 Running totals
Given a List of daily sales, print a running total after each day, and the day number on which
the cumulative total first passed 1000.

EXPECTED OUTPUT
Day 1: 250 (total 250)
Day 2: 300 (total 550)
Day 3: 180 (total 730)
Day 4: 420 (total 1150)
Day 5: 200 (total 1350)
Passed 1000 on day 4
*/

using System;
using System.Collections.Generic;

class Q2
{
    public static void Main(string[] args)
    {
        List<int> sales = new List<int>();

        Console.Write("Enter number of days: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter daily sales:");

        for (int i = 0; i < n; i++)
        {
            int sale = int.Parse(Console.ReadLine());
            sales.Add(sale);
        }

        int tot = 0;
        int passDay = -1;

        for (int i = 0; i < sales.Count; i++)
        {
            tot += sales[i];

            Console.WriteLine("Day " + (i + 1) + ": " + sales[i] +" (total " + tot + ")");
            if (tot > 1000 && passDay == -1)
            {
                passDay = i + 1;
            }
        }

        if (passDay != -1)
        {
            Console.WriteLine("Passed 1000 on day " + passDay);
        }
        else
        {
            Console.WriteLine("Did not pass 1000");
        }
    }
}