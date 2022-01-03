using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ChainOfResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Patient> lst = new List<Patient>();
			lst.Add(new Patient { Id = 1, Name = "A" });
			lst.Add(new Patient { Id = 2, Name = "B" });
			List<Patient> lst1 = new List<Patient>(lst);
			lst1.Remove(lst1.First());
			var a = Stopwatch.StartNew();
			a.Stop();

			var a = lst?.FirstOrDefault(p => p.Id == 1)?.Name;

			Console.WriteLine(a);

			if("a" == "b" && lst?.Count > 0)
			{

			}
			Sample obj = new Sample();
			int c = 1;
			long b = c;
			obj.display(c, b);
		}
	}

	public class Patient
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class Sample
	{
		public void display(int a, long b) { Console.WriteLine("display1"); }
		public void display(long a, int b) { Console.WriteLine("display2"); }
	}
}
