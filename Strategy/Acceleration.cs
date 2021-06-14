using System;

namespace Strategy
{
	class Acceleration : ISprintStrategy
	{
		public void ChangeStrategy()
		{
			Console.WriteLine("Acceleration phase");
		}
	}
}
