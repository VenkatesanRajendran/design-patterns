namespace Factory
{
	class PlatinumCreditCard : ICreditCard
	{
		public string CardType => "Platinum";
		public int CreditLimit
		{
			get
			{
				return 150000;
			}
		}
		public int AnnualCharge
		{
			get
			{
				return 5000;
			}
		}
	}
}
