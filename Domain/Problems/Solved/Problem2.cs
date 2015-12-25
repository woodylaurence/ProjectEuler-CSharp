using System;
using System.Runtime.InteropServices;

namespace ProjectEuler.Domain
{
	/// <summary>
	/// Problem 2: By considering the terms in the Fibonacci sequence whose values do not exceed four million,
	/// 		   find the sum of the even-valued terms.
	/// Answer: 4613732
	/// </summary>
	public class Problem2 : IProblem
	{
		public string Solve()
		{
			const int problemUpperLimit = 4000000;
			var f_n_2 = Math.GetNthFibonacciNumber(0);
			var f_n_1 = Math.GetNthFibonacciNumber(1);
			var f_n = 0;
			var sum = 0;

			while ((f_n = Math.GetNextFibonacciNumberAndUpdateValues(ref f_n_1, ref f_n_2)) < problemUpperLimit)
			{
				if (f_n.IsEven()) sum += f_n;
			}

			return sum.ToString();
		}
	}
}

