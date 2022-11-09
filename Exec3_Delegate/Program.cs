using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> soruce = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16 };
			Func<int,bool> isEven = x => x % 2 == 0;
			List<int>result = GetEvenItems(soruce, isEven);
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
		public static List<int> GetEvenItems(List<int>source,Func<int,bool>func) 
		{
			List<int> result = new List<int>();
			foreach (var item in source)
			{
				if (func(item)==true)
				{
					result.Add(item);
				}
			}
			return result;
		}
	}
}
