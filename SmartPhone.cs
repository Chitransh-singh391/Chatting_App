using System;

public interface ICallable{
	void Call();
}

interface IInternetEnabled{
	void Browse();
}

public class SmartPhone : ICallable,IInternetEnabled{
	public void Call(){
		Console.WriteLine("Calling...");
	}
	public void Browse(){
		Console.WriteLine("Browsing internet...");
	}
}

public class Test{
	public static void Main(){
		SmartPhone phone = new SmartPhone();
		phone.Call();
		phone.Browse();
	}
}

