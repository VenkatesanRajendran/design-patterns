namespace Factory
{
	public class SilverCardFactory : CreditCardFactory
	{
		public override ICreditCard GetCreditCard()
		{
			return new SilverCreditCard();
		}
	}
	public class GoldCardFactory : CreditCardFactory
	{
		public override ICreditCard GetCreditCard()
		{
			return new GoldCreditCard();
		}
	}
	public class PlatinumCardFactory : CreditCardFactory
	{
		public override ICreditCard GetCreditCard()
		{
			return new PlatinumCreditCard();
		}
	}
}
