using System;
using NUnit.Framework;
using Rhino.Mocks.Constraints;
using ProjectEuler.Domain;
using ProjectEuler.Tests.IntegrationTests.TestObjects;

namespace ProjectEuler.Tests.IntegrationTests
{
    [TestFixture]
    public class ProblemSolverIntegrationTests
    {
        [Test]
        [ExpectedException(typeof(Exception), ExpectedMessage = "This is what this problem does")]
        public void SolveProblem()
        {
            //act
            ProblemSolver.SolveProblem(new TestProblem());
        }
    }
}

