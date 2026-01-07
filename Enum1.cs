using System;

public class Enum1{
	public enum Days{
		Sunday = 1,
		Monday = 2,
		Tuesday = 3,
		Wednesday = 4,
		Thrusday = 5,
		Friday = 6,
		Saturday = 7
	};
	
	public Days day(int index){
		return (Days)index;
	}
}

public class Test{
	public static void Main(){
		Enum1 e1 = new Enum1();
		Console.Write(e1.day(2));
	}
}