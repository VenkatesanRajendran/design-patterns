using System;

namespace Strategy
{
	class Acceleration : ISprintStrategy
	{
		public void PerformAction()
		{
			Console.WriteLine("Acceleration phase");
		}
	}
}
