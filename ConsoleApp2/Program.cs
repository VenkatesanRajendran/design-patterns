using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Console.WriteLine(args[0] + args[1]);
			//A a = new A();
			//Console.WriteLine(a.ToString());
			//B b = new B();
			//A a1 = new B();
			//a.Print();
			//b.Print();
			//a1.Print();
			//object o = new object();
			//int i = 10;
			//o = i;
			//Console.WriteLine(i);
			string sampleText = "abc";
			var byteArray = Encoding.UTF8.GetBytes(sampleText);
			var sb = new StringBuilder();
			foreach (byte b in byteArray)
			{
				sb.Append(b.ToString("x2"));
			}
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			foreach (int i in GetEvenNumbers(numbers))
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
			Add(1, 2, out int d);
		}

		public static IEnumerable<int> GetEvenNumbers(List<int> numbers)
		{
			foreach (var number in numbers)
			{
				if (number % 2 == 0)
					yield return number;
			}
		}

		public static int Add(int a, int b, out int c)
		{
			c = a - b;
			return a + b;
		}
	}
}
