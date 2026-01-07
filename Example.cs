
using System;

public class Base{
	public Base(){
		Console.WriteLine("Base default called");
	}
	public Base(int a){
		Console.WriteLine("Base called");
	}
}

public class Child:Base{
	public Child(int a){
		Console.WriteLine("child called");
	}
}

public class Example{
	public static void Main(){
		Base c = new Child(6);
		
		
	}
}
