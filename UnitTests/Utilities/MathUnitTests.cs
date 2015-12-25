using System;
using NUnit.Framework;
using ProjectEuler.Domain;
using Rhino.Mocks;
using Math = ProjectEuler.Domain.Math;

namespace ProjectEuler.Tests.UnitTests
{
	[TestFixture]
	public class MathUnitTests
	{
		private MathConcreteObject _instance;

		[SetUp]
		public void Setup()
		{
			_instance = MockRepository.GeneratePartialMock<MathConcreteObject>();

			Math.MethodObject = MockRepository.GenerateStrictMock<MathConcreteObject>();
		}

		[TestFixtureTearDown]
		public void TearDown()
		{
			Math.MethodObject = new MathConcreteObject();
		}

		#region GetNthFibonacciNumber

		[Test]
		public void GetNthFibonacciNumber_calls_slave()
		{
			//arrange
			const int n = 4;
			const int expected = 676;
			Math.MethodObject.Expect(x => x.GetNthFibonacciNumberSlave(n)).Return(expected);

			//act
			var actual = Math.GetNthFibonacciNumber(n);

			//assert
			Math.MethodObject.VerifyAllExpectations();
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		public void GetNthFibonacciNumberSlave()
		{
			//arrange
			const int n = 4;
			const int expected = 51;

			var f_n_1 = 1;
			var f_n_2 = 0;

			Math.MethodObject.Expect(x => x.GetNextFibonacciNumberAndUpdateValuesSlave(ref f_n_1, ref f_n_2)).Return(1);
			Math.MethodObject.Expect(x => x.GetNextFibonacciNumberAndUpdateValuesSlave(ref f_n_1, ref f_n_2)).Return(2);
			Math.MethodObject.Expect(x => x.GetNextFibonacciNumberAndUpdateValuesSlave(ref f_n_1, ref f_n_2)).Return(expected);

			//act
			var actual = _instance.GetNthFibonacciNumberSlave(n);

			//assert
			Math.MethodObject.VerifyAllExpectations();
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion

		#region GetNextFibonacciNumber

		[Test]
		public void GetNextFibonacciNumber_calls_slave()
		{
			//arrange
			var f_n_1 = 6543;
			var f_n_2 = 651;
			const int expected = 515;

			Math.MethodObject.Expect(x => x.GetNextFibonacciNumberAndUpdateValuesSlave(ref f_n_1, ref f_n_2)).Return(expected);

			//act
			var actual = Math.GetNextFibonacciNumberAndUpdateValues(ref f_n_1, ref f_n_2);

			//assert
			Math.MethodObject.VerifyAllExpectations();
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion
	}
}

