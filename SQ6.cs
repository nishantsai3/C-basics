/*
6 Shopping list manager
Build a List of strings. Add four items, insert one at the start, remove one by value, remove one
by index, then print the final list with its count.

EXPECTED OUTPUT
Final list: Bread, Milk, Eggs
Items: 3
*/

using System;
class Program
{
    public static void Main(string[] args)
    {
        List<string> lst = new List<string>();

        Console.WriteLine("Enter 4 items:");

        for (int i = 0; i < 4; i++)
        {
            string item = Console.ReadLine();
            lst.Add(item);
        }

        Console.Write("Enter item to insert at start: ");
        string newitem = Console.ReadLine();

        lst.Insert(0, newitem);

        Console.Write("Enter item to remove by value: ");
        string rem = Console.ReadLine();

        lst.Remove(rem);

        Console.Write("Enter index to remove: ");
        int ind = int.Parse(Console.ReadLine());

        lst.RemoveAt(ind);

        Console.WriteLine("Final list: " + string.Join(", ", lst));
        Console.WriteLine("Items: " + lst.Count);
    }
}