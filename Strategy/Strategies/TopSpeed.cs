using System;

namespace Strategy
{
	class TopSpeed : ISprintStrategy
	{
		public void PerformAction()
		{
			Console.WriteLine("Top speed phase");
		}
	}
}
