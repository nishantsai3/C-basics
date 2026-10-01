/*
7 Separate evens and odds
Given a List of integers, build two new lists — one of the even numbers and one of the odd —
and print both along with their counts.

EXPECTED OUTPUT
Evens (3): 12, 8, 44
Odds (4): 7, 19, 3, 25
*/

using System;
class SQ7
{
    public static void Main(string[] args)
    {
        List<int> lst = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter numbers:");

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            lst.Add(num);
        }

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach (int num in lst)
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }

        Console.WriteLine("Evens (" + even.Count + "): " +
                          string.Join(", ", even));

        Console.WriteLine("Odds (" + odd.Count + "): " +
                          string.Join(", ", odd));
    }
}