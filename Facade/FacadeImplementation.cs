using System;

namespace Facade
{
	internal class FacadeImplementationOne
	{
		public void StepOne()
		{
			Console.WriteLine("Step one");
		}
		public void StepTwo()
		{
			Console.WriteLine("Step two");
		}
	}
	internal class FacadeImplementationTwo
	{
		public void StepThree()
		{
			Console.WriteLine("Step three");
		}
	}
	internal class FacadeImplementationThree
	{
		public void StepFour()
		{
			Console.WriteLine("Step four");
		}
	}
}
