using System;

namespace ConsoleApp2
{
	public interface IInterface
	{
		void Add();
		string GetString();
	} 

	internal class TestClass : IInterface
	{
		public void Add()
		{
			Console.WriteLine("A");
		}

		public string GetString()
		{
			return "B";
		}

		public int Add(int a, int b)
		{
			return a + b;
		}
	}
}
