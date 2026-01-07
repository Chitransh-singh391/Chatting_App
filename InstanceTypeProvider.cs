using System;
namespace csharp{
	public class InstanceTypeProvider{
		public static void Main(){
			//IVehicle car = VehicleFactory.Instance.GetVehicle("csharp.Car");
			IVehicle car = VehicleFactory.GetVehicle(VehicleType.Car);
			car.Start();
			IVehicle bus = VehicleFactory.GetVehicle(VehicleType.Bus);
			bus.Start();
		}
	}
}