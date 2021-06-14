using System.Collections.Generic;

namespace Decorator
{
	class BasicSandwich : ISandwich
	{
		public int Cost { get; set; }
		public List<string> Ingredients { get; set; } = new List<string>();

		public BasicSandwich()
		{
			Ingredients.Add("Sandwich");
			Cost = 20;
		}
	}
}
