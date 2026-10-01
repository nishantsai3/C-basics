/*
Count above and below average
Read an array of marks, compute the average, then report how many are above it, how many
below, and how many exactly equal it.
E X P E C T E D O U T P U T
Average: 78.80
Above: 2
Below: 3
Equal: 0

*/

using System;

class SQ3
{
    public static void Main(string[] args)
    {
        string inp = Console.ReadLine();
        int[] arr = Array.ConvertAll(inp.Split(","), int.Parse);
		int bef = 0;
		int aft = 0;
		int equal = 0;
		int sum = 0;
		foreach(int num in arr){
			sum+=num;
		}
		int avg = (int)sum/arr.Length;
		foreach(int num in arr){
			if(num<avg){
				bef++;
			}else if(num>avg){
				aft++;
			}else{
				equal++;
			}
		}
		Console.WriteLine(avg);
		Console.WriteLine("Bef : "+bef);
		Console.WriteLine("Aft : "+aft);
		Console.WriteLine("Equal : "+equal );
    }
}