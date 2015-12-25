using System;
using System.Xml;

namespace ProjectEuler.Domain
{
	public static class Math
	{
		internal static MathConcreteObject MethodObject = new MathConcreteObject();

		public static int GetNthFibonacciNumber(int n) { return MethodObject.GetNthFibonacciNumberSlave(n); }
		public static int GetNextFibonacciNumberAndUpdateValues(ref int f_n_1, ref int f_n_2) { return MethodObject.GetNextFibonacciNumberAndUpdateValuesSlave(ref f_n_1, ref f_n_2); }
	}

	public class MathConcreteObject
	{
		#region GetNthFibonacciNumber

		protected internal virtual int GetNthFibonacciNumberSlave(int n)
		{
			if (n < 0) throw new ArgumentException("n must be greater or equal to 0");
			if (n == 0)	return 0;
			if (n == 1) return 1;

			var f_n = 0;
			var f_n_1 = 1;
			var f_n_2 = 0;

			for (var i = 2; i <= n; i++)
			{
				f_n = Math.GetNextFibonacciNumberAndUpdateValues(ref f_n_1, ref f_n_2);
			}

			return f_n;
		}

		#endregion

		#region GetNextFibonacciNumberAndUpdateValues

		protected internal virtual int GetNextFibonacciNumberAndUpdateValuesSlave(ref int f_n_1, ref int f_n_2)
		{
			var f_n = f_n_1 + f_n_2;
			f_n_2 = f_n_1;
			f_n_1 = f_n;

			return f_n;
		}

		#endregion
	}
}

