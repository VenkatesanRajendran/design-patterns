using System;
using System.Collections.Generic;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Choose sandwich type");
			Console.WriteLine("1. Basic Sandwich");
			Console.WriteLine("2. Cheese Sandwich");
			Console.WriteLine("3. Paneer Sandwich");
			int n = Convert.ToInt16(Console.ReadLine());
			ISandwich sandwich = new BasicSandwich();
			switch (n)
			{
				case 1:
					break;
				case 2:
					new CheeseSandwich(sandwich);
					break;
				case 3:
					new PaneerSandwich(sandwich);
					break;
				default:
					break;
			}
			Console.WriteLine("Cost : " + sandwich.Cost);
			string ingredients = "";
			sandwich.Ingredients.ForEach(x => ingredients = x + ingredients);
			Console.WriteLine("Ingredients: " + ingredients);
			Console.Read();
		}
	}
	public class Restaurant
	{
		public string name;
		public List<string> items;
	}

}
