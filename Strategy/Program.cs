using System;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Sprint s = new Sprint(new Acceleration());
			s.ChangePhase();

			s = new Sprint(new Transition());
			s.ChangePhase();

			s = new Sprint(new TopSpeed());
			s.ChangePhase();

			Console.ReadLine();
		}
	}
}
