using System;
using System.Collections.Generic;
using Castle.Components.DictionaryAdapter.Xml;
using System.Linq;

namespace ProjectEuler.Domain.Problems
{
	/// <summary>
	/// Problem 1: Find the sum of all the multiples of 3 or 5 below 1000.
	/// Answer: 233168
	/// </summary>
	public class Problem1 : IProblem
	{
		public string Solve()
		{
			return Enumerable.Range(1, 999).Where(IsMultipleOfThreeOrFive).Sum().ToString();
		}

		protected internal virtual bool IsMultipleOfThreeOrFive(int number)
		{
			return number % 3 == 0 || number % 5 == 0;
		}
	}
}

