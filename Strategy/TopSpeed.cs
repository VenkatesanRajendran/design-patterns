using System;

namespace Strategy
{
	class TopSpeed : ISprintStrategy
	{
		public void ChangeStrategy()
		{
			Console.WriteLine("Top speed phase");
		}
	}
}
