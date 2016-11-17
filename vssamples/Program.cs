using System;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		var arr = new int[] { 1, 2, 3 };
		foreach (var item in arr.Select(x => x * 2))
		{
			Console.WriteLine(item);
		}
		Console.WriteLine("Hello World!");
	}
}
