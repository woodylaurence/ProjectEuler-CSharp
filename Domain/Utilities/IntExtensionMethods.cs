using System;

namespace ProjectEuler.Domain
{
	public static class IntExtensionMethods
	{
		internal static IntExtensionMethodsConcreteObject MethodObject = new IntExtensionMethodsConcreteObject();

		public static bool IsEven(this int number) { return MethodObject.IsEvenSlave(number); }
		public static bool IsPrime(this int number) { throw new NotImplementedException(); }
	}

	public class IntExtensionMethodsConcreteObject
	{
		protected internal virtual bool IsEvenSlave(int number)
		{
			return (number & 1) == 0;
		}

		protected internal virtual bool IsPrime(int number)
		{
			throw new NotImplementedException();
		}
	}
}

