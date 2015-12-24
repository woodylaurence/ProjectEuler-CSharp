using System;
using Castle.Windsor;
using Microsoft.Practices.ServiceLocation;
using Castle.Windsor.Installer;

namespace ProjectEuler.Domain
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ProblemSolver.SolveProblem(null);
		}

		public static void SetupWindsorContainer()
		{
			throw new NotImplementedException ("This does not work, sounds like missing mscorlib dll");
			//			var container = new WindsorContainer();
			//			container.Install(Configuration.FromAppConfig());
		}
	}
}

