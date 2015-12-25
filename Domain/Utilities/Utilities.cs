using System;
using System.Collections.Generic;

namespace ProjectEuler.Domain
{
	public static class Utilities
	{
		internal static UtilitiesConcreteObject MethodObject = new UtilitiesConcreteObject();

		public static List<int> GetDigits(int number) { return MethodObject.GetDigitsSlave(number); }
	}

	public class UtilitiesConcreteObject
	{
		#region GetDigits

		protected internal virtual List<int> GetDigitsSlave(int number)
		{
			var digits = new List<int>();
			number = Math.Abs(number);

			if (number == 0) return  new List<int> { 0 };
			while (number > 0)
			{
				digits.Add(number % 10);
				number /= 10;
			}

			digits.Reverse();
			return digits;
		}

		#endregion
	}
}

