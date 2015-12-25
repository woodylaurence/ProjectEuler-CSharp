using System;
using NUnit.Framework;
using ProjectEuler.Domain;

namespace ProjectEuler.Tests.IntegrationTests
{
	[TestFixture]
	public class IntExtensionMethodsIntegrationTests
	{
		#region IsEven

		[TestCase(0, true)]
		[TestCase(1, false)]
		[TestCase(16, true)]
		[TestCase(61573, false)]
		[TestCase(-4, true)]
		[TestCase(-15, false)]
		public void IsEven(int number, bool expected)
		{
			//act
			var actual = number.IsEven();

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion
	}
}

