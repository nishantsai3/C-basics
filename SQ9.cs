/*
9 Merge two lists without duplicates
Given two Lists of integers, produce a single list containing every value from both, with no
value appearing twice. Use Contains to check. Print it sorted.

EXPECTED OUTPUT
List A: 3, 7, 1, 9
List B: 7, 4, 9, 2
Merged: 1, 2, 3, 4, 7, 9
*/

using System;
class SQ9
{
    public static void Main(string[] args)
    {
        List<int> listA = new List<int>();
        List<int> listB = new List<int>();

        Console.Write("Enter number of elements in List A: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter List A:");

        for (int i = 0; i < n1; i++)
        {
            int num = int.Parse(Console.ReadLine());
            listA.Add(num);
        }

        Console.Write("Enter number of elements in List B: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter List B:");

        for (int i = 0; i < n2; i++)
        {
            int num = int.Parse(Console.ReadLine());
            listB.Add(num);
        }

        List<int> merged = new List<int>();

        foreach (int num in listA)
        {
            if (!merged.Contains(num))
                merged.Add(num);
        }

        foreach (int num in listB)
        {
            if (!merged.Contains(num))
                merged.Add(num);
        }

        merged.Sort();

        Console.WriteLine("List A: " + string.Join(", ", listA));
        Console.WriteLine("List B: " + string.Join(", ", listB));
        Console.WriteLine("Merged: " + string.Join(", ", merged));
    }
}