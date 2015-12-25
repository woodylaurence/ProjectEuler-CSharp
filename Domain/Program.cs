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
//			SetupWindsorContainer();
			ProblemSolver.SolveProblem(new Problem1() );
		}

		public static void SetupWindsorContainer()
		{
			throw new NotImplementedException("Need to work out how this works");
//			var container = new WindsorContainer();
//			container.Install(Configuration.FromAppConfig());
//			ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator);
		}
	}
}

