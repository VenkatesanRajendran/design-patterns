namespace Factory
{
	public class VehicleFactory : IVehicleFactory
	{
		public IVehicle GetVehicle(VehicleType vehicleType)
		{
			if (vehicleType.Equals(VehicleType.Bike))
				return new Bike();
			else
				return new Car();
		}
	}
}
