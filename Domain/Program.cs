using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Microsoft.Practices.ServiceLocation;
using ProjectEuler.Domain.Problems;

namespace ProjectEuler.Domain
{
	public class Program
	{
		public static void Main(string[] args)
		{
//			SetupWindsorContainer();
			ProblemSolver.SolveProblem(new Problem2() );
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

