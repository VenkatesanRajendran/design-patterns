using System;

namespace Singleton
{
	public sealed class SingletonClass
	{
		////Eager Initialization
		//private static readonly SingletonClass s = new SingletonClass();

		//public static SingletonClass Instance
		//{
		//	get { return s; }
		//}

		////Lazy initialization
		//private static SingletonClass s = null;

		//public static SingletonClass Instance
		//{
		//	get
		//	{
		//		if (s == null)
		//			s = new SingletonClass();

		//		return s;
		//	}
		//}

		//Thread safe Initialization
		private static SingletonClass s = null;
		private static readonly object obj = new object();

		private SingletonClass()
		{

		}

		public static SingletonClass Instance
		{
			get
			{
				lock (obj)
				{
					if (s == null)
					{
						s = new SingletonClass();
					}
				}

				return s;
			}
		}

		public void PrintDetails()
		{
			Console.WriteLine("PrintDetails invoked using singleton");
		}

	}
}
