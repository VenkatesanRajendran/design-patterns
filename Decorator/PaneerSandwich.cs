using System.Collections.Generic;

namespace Decorator
{
	class PaneerSandwich : ISandwich
	{
		public int Cost { get; set; }
		public List<string> Ingredients { get; set; }

		public PaneerSandwich(ISandwich sandwich)
		{
			sandwich.Ingredients.Add("Paneer");
			sandwich.Cost = sandwich.Cost + 15;
		}
	}
}