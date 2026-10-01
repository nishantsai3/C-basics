/*
Second largest value
Find the second largest number in an array in a single pass. Do not sort the array.

EXPECTED OUTPUT
Numbers: 23, 91, 45, 91, 12
Largest: 91
Second largest: 45
*/

using System;
class SQ4
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter the numbers:");

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int largest = int.MinValue;
        int secLargest = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                secLargest = largest;
                largest = num;
            }
            else if (num > secLargest && num != largest)
            {
                secLargest = num;
            }
        }

        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Second largest: " + secLargest);
    }
}