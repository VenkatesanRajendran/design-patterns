using System;

namespace Strategy
{
	class Transition : ISprintStrategy
	{
		public void PerformAction()
		{
			Console.WriteLine("Transition phase");
		}
	}
}
