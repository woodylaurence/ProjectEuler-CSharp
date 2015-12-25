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
		[TestCase(-5826, new int[] { 5, 8, 2, 6 })]
		public void GetDigits(int number, int[] expectedDigits)
		{
			//act
			var actual = Utilities.GetDigits(number);

			//assert
			Assert.That(actual, Has.Count.EqualTo(expectedDigits.Length));
			Assert.That(actual, Is.EqualTo(expectedDigits.ToList()));
		}

		#endregion
	}
}

