using System;

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
			Person a = new Person();
			a.Name = "Arun";
			a.Age = 20;
			a.address = new Address("1", "2");

			Person b = a;
			a.Age = 25;
			a.address.LineOne = "sdfgsg";
			Console.WriteLine(a.Age);
			Console.WriteLine(b.Age);
			Console.WriteLine(a.address.LineOne);
			Console.WriteLine(a.address.LineOne);


			Console.ReadLine();
		}
	}

	public class Person
	{
		public string Name;
		public int Age;
		protected int Salary;
		public Address address;

		public Person() : this("test")
		{
			Console.WriteLine("Constructor A");
		}

		private Person(string name)
		{
			Console.WriteLine(name);
		}

		public void Print()
		{
			Console.WriteLine("Print A");
		}

		public override string ToString()
		{
			return Name;
		}
	}

	public class Address
	{
		public string LineOne;
		public string LineTwo;

		public Address(string v1, string v2)
		{
			LineOne = v1;
			LineTwo = v2;
		}
	}

	class B : Person
	{
		public string gender;

		public B()
		{
			Console.WriteLine("Constructor B");
		}
		public new void Print()
		{
			Console.WriteLine("Print B");
		}
		public void MethodB()
		{

		}
	}
}
