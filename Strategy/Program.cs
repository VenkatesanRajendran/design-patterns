using System;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Sprint s = new Sprint();
			s.ChangeStrategy(new Acceleration());
			s.DoAction();

			s.ChangeStrategy(new Transition());
			s.DoAction();

			s.ChangeStrategy(new TopSpeed());
			s.DoAction();

			Console.ReadLine();
		}
	}
}
