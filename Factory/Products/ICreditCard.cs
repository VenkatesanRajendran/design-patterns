namespace Factory
{
	public interface ICreditCard
	{
		string CardType { get; }
		int CreditLimit { get; }
		int AnnualCharge { get; }
	}
}
