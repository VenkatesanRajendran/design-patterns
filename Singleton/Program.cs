using System;

namespace Singleton
{
	public class Program
	{
		public static void Main(string[] args)
		{
			SingletonClass.Instance.PrintDetails();
			Console.Read();
		}
	}
}
