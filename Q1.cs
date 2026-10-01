/*
1 Rotate an array
Rotate an integer array to the right by k positions, without using any built-in rotate helper. Print
the array before and after.

EXPECTED OUTPUT
Before: 1 2 3 4 5 6 7
k = 3
After: 5 6 7 1 2 3 4
*/

using System;
class Q1
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Before: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        k = k % n;

        for (int r = 0; r < k; r++)
        {
            int last = arr[n - 1];

            for (int i = n - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = last;
        }

        Console.WriteLine();
        Console.Write("After: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}