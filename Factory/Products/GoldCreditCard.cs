namespace Factory
{
	class GoldCreditCard : ICreditCard
	{
		public string CardType => "Gold";
		public int CreditLimit
		{
			get
			{
				return 100000;
			}
		}
		public int AnnualCharge
		{
			get
			{
				return 1000;
			}
		}
	}
}
