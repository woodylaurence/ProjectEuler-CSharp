using System;
using ProjectEuler.Domain;

namespace ProjectEuler.Tests.IntegrationTests.TestObjects
{
    public class TestProblem : IProblem
    {
        public string Solve()
        {
            throw new Exception("This is what this problem does");
        }
    }
}

