using System;
using System.Diagnostics;
using Castle.Core.Logging;

namespace ProjectEuler.Domain
{
	public class ProblemSolver
	{
		internal static ProblemSolver MethodObject = new ProblemSolver();

		#region SolveProblem

        public static void SolveProblem(IProblem problem) { MethodObject.SolveProblemSlave(problem); }
		protected internal virtual void SolveProblemSlave(IProblem problem)
		{
            var stopwatch = Stopwatch.StartNew();
            var answer = problem.Solve();
            stopwatch.Stop();

            Console.WriteLine(string.Format("Answer: {0}", answer));
            Console.WriteLine(string.Format("Took {0}ms to run...", stopwatch.ElapsedMilliseconds));
		}

		#endregion
	}
}