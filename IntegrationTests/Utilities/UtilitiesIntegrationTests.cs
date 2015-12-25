using System;
using NUnit.Framework;
using ProjectEuler.Domain;
using Castle.Components.DictionaryAdapter.Xml;
using System.Linq;

namespace ProjectEuler.Tests.IntegrationTests
{
	[TestFixture]
	public class UtilitiesIntegrationTests
	{
		#region GetDigits

		[TestCase(0, new int[] { 0 })]
		[TestCase(4, new int[] { 4 })]
		[TestCase(4515, new int[] { 4, 5, 1, 5 })]
		[TestCase(9223372036854775807, new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7 })]
		[TestCase(-5826, new int[] { 5, 8, 2, 6 })]
		public void GetDigits(long number, int[] expectedDigits)
		{
			//act
			var actual = Utilities.GetDigits(number);

			//assert
			Assert.That(actual, Has.Count.EqualTo(expectedDigits.Length));
			Assert.That(actual, Is.EqualTo(expectedDigits.ToList()));
		}

		#endregion

		#region GetSumDigits

		[TestCase(0, 0)]
		[TestCase(14, 5)]
		[TestCase(41, 5)]
		[TestCase(2076123456, 36)]
		public void GetSumDigits(int number, int expected)
		{
			//act
			var actual = Utilities.GetSumDigits(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion

		#region GetNumDigits

		[TestCase(0, 1)]
		[TestCase(09, 1)]
		[TestCase(91, 2)]
		[TestCase(2076123456, 10)]
		public void GetNumDigits(int number, int expected)
		{
			//act
			var actual = Utilities.GetNumDigits(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion
	}
}

