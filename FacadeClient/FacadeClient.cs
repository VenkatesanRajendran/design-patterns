using Facade;

namespace FacadeClient
{
	public class FacadeClient
    {
		public static void Main(string[] args)
		{
			FacadeClass facade = new FacadeClass();
			facade.ActionOne();
			facade.ActionTwo();
		}
	}
}
