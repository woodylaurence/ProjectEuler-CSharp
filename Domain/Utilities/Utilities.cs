using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Domain
{
	public static class Utilities
	{
		internal static UtilitiesConcreteObject MethodObject = new UtilitiesConcreteObject();

		public static List<int> GetDigits(long number) { return MethodObject.GetDigitsSlave(number); }
		public static int GetSumDigits(int number) { return MethodObject.GetSumDigitsSlave(number); }
		public static int GetNumDigits(int number) { return MethodObject.GetNumDigitsSlave(number); }
	}

	public class UtilitiesConcreteObject
	{
		#region GetDigits

		protected internal virtual List<int> GetDigitsSlave(long number)
		{
			var digits = new List<int>();
			number = Math.Abs(number);

			if (number == 0) return  new List<int> { 0 };
			while (number > 0)
			{
				digits.Add((int)(number % 10));
				number /= 10;
			}

			digits.Reverse();
			return digits;
		}

		#endregion

		#region GetSumDigits

		protected internal virtual int GetSumDigitsSlave(int number)
		{
			return Utilities.GetDigits(number).Sum(x => x);
		}

		#endregion

		#region GetNumDigits

		protected internal virtual int GetNumDigitsSlave(int number)
		{
			return Utilities.GetDigits(number).Count;
		}

		#endregion
	}
}

