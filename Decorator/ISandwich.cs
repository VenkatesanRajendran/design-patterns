using System.Collections.Generic;

namespace Decorator
{
	interface ISandwich
	{
		int Cost { get; set; }

		List<string> Ingredients { get; set; }
	}
}
