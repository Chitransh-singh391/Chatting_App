using System;



public partial class Vehicle{
	partial void part2(){
		Console.WriteLine("vehicle is running");
	}
	
	partial void part2(int a){
		Console.WriteLine("vehicle has {0} wheels",a);
	}
}