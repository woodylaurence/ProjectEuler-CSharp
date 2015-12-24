using System;
using NUnit.Framework;
using Rhino.Mocks;
using Castle.Windsor;
using ProjectEuler.Domain;

namespace ProjectEuler.Tests.UnitTests
{
	[TestFixture]
	public class ProblemSolverUnitTests
	{
		private ProblemSolver _instance;
		private IProblem _problem;

		[SetUp]
		public void Setup()
		{
			_instance = MockRepository.GeneratePartialMock<ProblemSolver>();
			_problem = MockRepository.GenerateStrictMock<IProblem>();

			ProblemSolver.MethodObject = MockRepository.GenerateStrictMock<ProblemSolver>();
		}

		[TestFixtureTearDown]
		public void TearDown()
		{
			ProblemSolver.MethodObject = new ProblemSolver();
		}

		#region SolveProblem

		[Test]
		public void SolveProblem_calls_slave()
		{
			//arrange
			ProblemSolver.MethodObject.Expect(x => x.SolveProblemSlave(_problem));

			//act
			ProblemSolver.SolveProblem(_problem);

			//assert
			ProblemSolver.MethodObject.VerifyAllExpectations();
		}

		[Test]
		public void SolveProblemSlave()
		{
			//arrange
            

			//act
			_instance.SolveProblemSlave(_problem);

			//assert
			_problem.VerifyAllExpectations();
		}

		#endregion
	}
}

