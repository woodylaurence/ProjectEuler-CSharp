using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using NUnit.Framework;
using ProjectEuler.Domain;
using Rhino.Mocks;

namespace ProjectEuler.Tests.UnitTests
{
	[TestFixture]
	public class UtilitiesUnitTests
	{
		[SetUp]
		public void Setup()
		{
			Utilities.MethodObject = MockRepository.GenerateStrictMock<UtilitiesConcreteObject>();
		}

		[TestFixtureTearDown]
		public void TearDown()
		{
			Utilities.MethodObject = new UtilitiesConcreteObject();
		}

		#region GetDigits

		[Test]
		public void GetDigits_calls_slave()
		{
			//arrange
			const int number = 4;
			var expected = new List<int> { 4 };
			Utilities.MethodObject.Stub(x => x.GetDigitsSlave(number)).Return(expected);

			//act
			var actual = Utilities.GetDigits(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion
	}
}

