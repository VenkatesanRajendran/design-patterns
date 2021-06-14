namespace Facade
{
	public class FacadeClass
	{
		FacadeImplementationOne fi;
		FacadeImplementationTwo fi2;
		FacadeImplementationThree fi3;

		public FacadeClass()
		{
			fi = new FacadeImplementationOne();
			fi2 = new FacadeImplementationTwo();
			fi3 = new FacadeImplementationThree();
		}

		public void ActionOne()
		{
			fi.StepOne();
			fi.StepTwo();
		}

		public void ActionTwo()
		{
			fi2.StepThree();
			fi3.StepFour();
		}
	}
}
