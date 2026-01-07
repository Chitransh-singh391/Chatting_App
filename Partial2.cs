using System;

public partial class Vehicle
{
	public Vehicle(){
		Console.WriteLine("this vehicle constructor");
	}
	partial void part2();
	partial void part2(int a);
    public void Start(int a) { 
	Console.WriteLine("vehicle is started");
	part2();
	part2(a);
	}
}

public class Car : Vehicle
{
	public Car(){
		Console.WriteLine("this car constructor");
	}
	public new void Start(int a){
		//base.Start();
		Console.WriteLine("car is started");
	}
	
	
}


public class Test{
	
	
	public static void Main(){
		Vehicle v1 = new Car();
		Vehicle v2 = (Vehicle)v1; //down casting
		v2.Start(4);
		
	}
}
//*/
//compiled as :- csc Partial.cs Partial2.cs
//run as:- Partial2





