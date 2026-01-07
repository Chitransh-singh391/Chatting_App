using System;

namespace csharp{
	
	public enum VehicleType
	{
		Car,
		Bike,
		Bus
	}
	public interface IVehicle{
		void Start();
	}

	public class Car:IVehicle{
		public void Start(){
			Console.WriteLine("car has been started");
		}
	}

	public class Bike:IVehicle{
		public void Start(){
			Console.WriteLine("bike has been started");
		}
	}

	public class Bus:IVehicle{
		public void Start(){
			Console.WriteLine("Bus has been started");
		}
	}
	



	public class VehicleFactory{
		//private static readonly VehicleFactory _instance = new VehicleFactory();
		private static readonly Car _car = new Car();
        private static readonly Bike _bike = new Bike();
        private static readonly Bus _bus = new Bus();

        //public static VehicleFactory Instance => _instance;
		public static IVehicle GetVehicle(VehicleType type){
			//Type type = Type.GetType(vehicle);
			switch(type)
			{
				case VehicleType.Car:
					return _car;
				case VehicleType.Bike:
					return _bike;
				case VehicleType.Bus:
					return _bus;
				default:
					throw new ArgumentException("Invalid vehicle type");
			}
			
			//without Singleton pattern
			//if(type == null || !typeof(IVehicle).IsAssignableFrom(type)){
			//	throw new ArgumentException("Invalid");
			//}
			//return (IVehicle)Activator.CreateInstance(type);
		}
	}
}



