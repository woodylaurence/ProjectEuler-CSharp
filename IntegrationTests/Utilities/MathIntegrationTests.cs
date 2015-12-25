using System;
using NUnit.Framework;
using Math = ProjectEuler.Domain.Math;

namespace ProjectEuler.Tests.IntegrationTests
{
	[TestFixture]
	public class MathIntegrationTests
	{
		#region GetNthFibonacciNumber

		[TestCase(0, 0)]
		[TestCase(1, 1)]
		[TestCase(2, 1)]
		[TestCase(3, 2)]
		[TestCase(7, 13)]
		[TestCase(45, 1134903170)]
		public void GetNthFibonacciNumber(int n, int expected)
		{
			//act
			var actual = Math.GetNthFibonacciNumber(n);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[TestCase(-1)]
		[TestCase(-76242)]
		[ExpectedException(typeof(ArgumentException), ExpectedMessage = "n must be greater or equal to 0")]
		public void GetNthFibonacciNumber_WHERE_n_is_negative_SHOULD_throw_error(int n)
		{
			//act
			Math.GetNthFibonacciNumber(n);
		}

		#endregion

		#region GetNextFibonacciNumberAndUpdateValues

		[TestCase(1, 1, 2)]
		[TestCase(2, 3, 5)]
		[TestCase(13, 21, 34)]
		public void GetNextFibonacciNumberAndUpdateValues(int f_n_2, int f_n_1, int expected)
		{
			//arrange
			var initial_f_n_2 = f_n_2;
			var initial_f_n_1 = f_n_1;

			//act
			var actual = Math.GetNextFibonacciNumberAndUpdateValues(ref f_n_1, ref f_n_2);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
			Assert.That(f_n_2, Is.EqualTo(initial_f_n_1));
			Assert.That(f_n_1, Is.EqualTo(expected));
		}

		#endregion
	}
}

