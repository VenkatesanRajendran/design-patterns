using System.Collections.Generic;

namespace Decorator
{
	class CheeseSandwich : ISandwich
	{
		public int Cost { get; set; }
		public List<string> Ingredients { get; set; }

		public CheeseSandwich(ISandwich sandwich)
		{
			sandwich.Ingredients.Add("Cheese");
			sandwich.Cost = sandwich.Cost + 10;
		}
	}
}
