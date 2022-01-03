using System;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Person a = new Person();
			a.Name = "Arun";
			a.Age = 20;
			a.address = new Address("Rajaji Nagar", "4th Street");

			Person c = a.ShallowCopy();
			Person d = a.DeepCopy();
			Console.WriteLine("Before change");
			Console.WriteLine(a.Age);
			Console.WriteLine(a.address.LineOne);
			a.Age = 25;
			a.address.LineOne = "Thanigai Nagar";
			Console.WriteLine("--------------");
			Console.WriteLine("After change");
			Console.WriteLine("Shallow copy "+c.Age);
			Console.WriteLine("Deep copy " + d.Age);
			Console.WriteLine("Shallow copy " + c.address.LineOne);
			Console.WriteLine("Deep copy " + d.address.LineOne);

			Console.ReadLine();
		}
	}
}
