using System;
using NUnit.Framework;
using ProjectEuler.Domain;
using Rhino.Mocks;

namespace ProjectEuler.Tests.UnitTests
{
	[TestFixture]
	public class IntExtensionMethodsUnitTests
	{
		[SetUp]
		public void Setup()
		{
			IntExtensionMethods.MethodObject = MockRepository.GenerateStrictMock<IntExtensionMethodsConcreteObject>();
		}

		[TestFixtureTearDown]
		public void TearDown()
		{
			IntExtensionMethods.MethodObject = new IntExtensionMethodsConcreteObject();
		}

		#region IsEven

		[Test]
		public void IsEven_calls_slave()
		{
			//arrange
			const int number = 514;
			IntExtensionMethods.MethodObject.Expect(x => x.IsEvenSlave(number)).Return(true);

			//act
			var actual = number.IsEven();

			//assert
			IntExtensionMethods.MethodObject.VerifyAllExpectations();
			Assert.That(actual);
		}

		#endregion
	}
}

