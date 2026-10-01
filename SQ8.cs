/*
8 Remove safely while iterating
Given a List of names, remove every name shorter than five characters. The obvious foreach
approach throws at runtime — solve it two different ways and explain why each works.

EXPECTED OUTPUT
Before: Amit, Priya, Kiran, Raj, Meera
After: Priya, Kiran, Meera
*/

using System;
class SQ8
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string>();

        Console.Write("Enter number of names: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter names:");

        for (int i = 0; i < n; i++)
        {
            names.Add(Console.ReadLine());
        }

        Console.WriteLine("Before: " + string.Join(", ", names));

        for (int i = names.Count - 1; i >= 0; i--)
        {
            if (names[i].Length < 5)
            {
                names.RemoveAt(i);
            }
        }

        Console.WriteLine("After: " + string.Join(", ", names));

    }
}