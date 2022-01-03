namespace Factory
{
	class SilverCreditCard : ICreditCard
	{
		public string CardType => "Silver";
		public int CreditLimit
		{
			get
			{
				return 50000;
			}
		}
		public int AnnualCharge
		{
			get
			{
				return 0;
			}
		}
	}
}
