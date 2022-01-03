namespace Prototype
{
	public class Person
	{
		public string Name;
		public int Age;
		protected int Salary;
		public Address address;

		public Person ShallowCopy()
		{
			return (Person)this.MemberwiseClone();
		}
		public Person DeepCopy()
		{
			Person clone = (Person)this.MemberwiseClone();
			clone.address = new Address(clone.address.LineOne, clone.address.LineTwo);
			clone.Name = string.Copy(Name);
			return clone;
		}
	}

	public class Address
	{
		public string LineOne;
		public string LineTwo;

		public Address(string v1, string v2)
		{
			LineOne = v1;
			LineTwo = v2;
		}
	}
}
