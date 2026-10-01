/*
1 Sum, average, highest and lowest
Given an array of marks, print the total, the average to two decimals, the highest and the
lowest. Do not use any built-in helper such as Array.Sort or Max — write the loops yourself.
E X P E C T E D O U T P U T
Marks: 78, 92, 65, 88, 71
Total: 394
Average: 78.80
Highest: 92
Lowest: 65
*/

using System;

class SQ1
{
    static void Main()
    {
        string inp = Console.ReadLine();
        int[] marks = Array.ConvertAll(inp.Split(','), int.Parse);
        int sum = 0;
        int highest = marks[0];
        int lowest = marks[0];

        for (int i = 0; i < marks.Length; i++)
        {
            sum+=marks[i];
            if (marks[i] > highest)
                highest = marks[i];
            if (marks[i] < lowest)
                lowest = marks[i];
        }
        double average = (double)sum / marks.Length;
        Console.WriteLine("Total: " + sum);
        Console.WriteLine("Average: " + average.ToString("F2"));
        Console.WriteLine("Highest: " + highest);
        Console.WriteLine("Lowest: " + lowest);
    }
}