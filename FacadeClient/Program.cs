using System;
using Facade;

namespace FacadeClient
{
	public class Program
    {
		public static void Main(string[] args)
		{
			FacadeClass facade = new FacadeClass();
			facade.ActionOne();
			facade.ActionTwo();
			Console.ReadLine();
		}
	}
}
