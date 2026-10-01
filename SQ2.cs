/*
Reverse an array in place
Reverse the contents of an integer array without creating a second array and without using
Array.Reverse. Print it before and after.
E X P E C T E D O U T P U T
Before: 1 2 3 4 5
After: 5 4 3 2 1
*/

using System;

class SQ2
{
    public static void Main(string[] args)
    {
        string inp = Console.ReadLine();

        int[] arr = Array.ConvertAll(inp.Split(","), int.Parse);

        Console.Write("Before: ");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }

        Console.Write("\nAfter: ");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}