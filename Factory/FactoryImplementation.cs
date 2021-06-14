using System;

namespace Factory
{
	public class FactoryImplementation
	{
		public static void Main()
		{
			IVehicle bike = new VehicleFactory().GetVehicle(VehicleType.Bike);
			Console.WriteLine(bike.GetNumberOfWheels());

			IVehicle car = new VehicleFactory().GetVehicle(VehicleType.Car);
			Console.WriteLine(car.GetNumberOfWheels());

		}
	}
}
