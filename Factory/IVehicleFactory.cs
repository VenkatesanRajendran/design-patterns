namespace Factory
{
	interface IVehicleFactory
	{
		IVehicle GetVehicle(VehicleType vehicleType);
	}
}
