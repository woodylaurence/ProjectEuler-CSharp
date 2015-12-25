using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using NUnit.Framework;
using ProjectEuler.Domain;
using Rhino.Mocks;
using Castle.Components.DictionaryAdapter.Xml;
using System.Linq;

namespace ProjectEuler.Tests.UnitTests
{
	[TestFixture]
	public class UtilitiesUnitTests
	{
		private UtilitiesConcreteObject _instance;

		[SetUp]
		public void Setup()
		{
			_instance = MockRepository.GeneratePartialMock<UtilitiesConcreteObject>();

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
			const long number = 4;
			var expected = new List<int> { 4 };
			Utilities.MethodObject.Stub(x => x.GetDigitsSlave(number)).Return(expected);

			//act
			var actual = Utilities.GetDigits(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion

		#region GetSumDigits

		[Test]
		public void GetSumDigits_calls_slave()
		{
			//arrange
			const int number = 815;
			const int expected = 13;
			Utilities.MethodObject.Stub(x => x.GetSumDigitsSlave(number)).Return(expected);

			//act
			var actual = Utilities.GetSumDigits(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		public void GetSumDigitsSlave()
		{
			//arrange
			const int number = 471;
			const int expected = 12;

			var digits = new List<int> { 4, 7, 1 };
			Utilities.MethodObject.Stub(x => x.GetDigitsSlave(number)).Return(digits);

			//act
			var actual = _instance.GetSumDigitsSlave(number);

			//assert
			Assert.That(actual, Is.EqualTo(digits.Sum(x => x)));
		}

		#endregion

		#region GetNumDigits

		[Test]
		public void GetNumDigits_calls_slave()
		{
			//arrange
			const int number = 815;
			const int expected = 3;
			Utilities.MethodObject.Stub(x => x.GetNumDigitsSlave(number)).Return(expected);

			//act
			var actual = Utilities.GetNumDigits(number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion
	}
}

