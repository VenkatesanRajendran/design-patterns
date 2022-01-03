using System;

namespace Factory
{
	public class Program
	{
		public static void Main()
		{
			CreditCardFactory factory = null;
			Console.WriteLine("Choose the credit card type from below: ");
			Console.WriteLine("1. Silver card");
			Console.WriteLine("2. Gold card");
			Console.WriteLine("3. Platinum card");
			int cardTypeId = Convert.ToInt16(Console.ReadLine());
			switch(cardTypeId)
			{
				case 1:
					factory = new SilverCardFactory();
					break;
				case 2:
					factory = new GoldCardFactory();
					break;
				case 3:
					factory = new PlatinumCardFactory();
					break;
			}
			ICreditCard creditCard = factory.GetCreditCard();
			Console.WriteLine("Card type: " + creditCard.CardType);
			Console.WriteLine("Credit limit: " + creditCard.CreditLimit);
			Console.WriteLine("Annual charge: " + creditCard.AnnualCharge);
			Console.ReadLine();
		}
	}
}
