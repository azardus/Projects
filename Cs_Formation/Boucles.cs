using System;
using System.Collections.Generic;
					
public class Program
{
	static List<int> ints;
	
	static private void PrintPoints(int nb)
	{
		for (int i = nb; i > 0; i--)
		{
			// [i].
			Console.Write("[" + i + "]");
		}
	}
	
	static private void PrintElements(int nb)
	{
		if (nb < ints.Count && nb > 0)
		{	
			for (int i = 0; i < nb; i++)// 
			{
				int value;
				value = ints[i];
				Console.Write("[" + value + "]");
			}
		}
		else
		{
			Console.WriteLine("Vous devez donner une valeur < au nombre d'élément du tableau et > 0");
		}
			
	}
	
	static public void Main()
	{
		ints = new List<int>();
		ints.Add(42); // [0]
		ints.Add(25); // [1]
		ints.Add(12); // [2]
		ints.Add(27); // [3]
		ints.Add(27); // [4]
		
		while (true)
		{
			int nb = int.Parse(Console.ReadLine());

			PrintElements(nb);
			Console.WriteLine();
		}
	}
}