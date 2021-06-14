using System;

namespace Strategy
{
	class Transition : ISprintStrategy
	{
		public void ChangeStrategy()
		{
			Console.WriteLine("Transition phase");
		}
	}
}
