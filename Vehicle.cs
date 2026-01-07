using System;

interface Vehicle{
	void CalculateRent(int days);
}

public class Car : Vehicle{
	protected readonly int rent = 1000;
	public void CalculateRent(int days){
	Console.WriteLine("Total rent for Car({0} days): {1}" ,days,rent * days);
	}
	
}

class Test{
	public static void Main(){
		Vehicle v = new Car();
		Car v1 = new Car();
		
		v.CalculateRent(3);
	}
}



