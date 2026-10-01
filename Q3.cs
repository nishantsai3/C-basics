/*
3 Find duplicates in a list
Given a List of integers, print every value that appears more than once, along with how many
times. Use a Dictionary to count.

EXPECTED OUTPUT
Numbers: 3, 7, 3, 9, 7, 1, 3
Duplicates:
3 appears 3 times
7 appears 2 times
*/

using System;
using System.Collections.Generic;

class Q3
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the numbers:");

        for (int i = 0; i < n; i++)
        {
            nums.Add(int.Parse(Console.ReadLine()));
        }

        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        Console.WriteLine("Duplicates:");

        foreach (KeyValuePair<int, int> item in count)
        {
            if (item.Value > 1)
            {
                Console.WriteLine(item.Key +" appears " +item.Value +" times");
            }
        }
    }
}