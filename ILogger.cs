using System;

public interface ILogger{
	void Log(string message);
}

//File Logger implementation
public class FileLogger : ILogger{
	public void Log(string message){
		Console.Log("Log written to file: "+message);
	}
}

//Console Logger implementation
public class ConsoleLogger : ILogger{
	public void Log(string message){
		Console.Log("Log written to Console: "+message);
	}
}

public class OrderService{
	private readonly ILogger logger;
	//Dependency is injected through constructor
	public OrderService(ILogger logger){
		this.logger = logger;
	}
	
	public void Placeorder(){
		logger.Log("order placed successfully");
	}
}

public class Program{
	public static void Main(){
		//DI in action - choose logger at runtime
		ILogger logger = new FileLogger();
		//you can switch to ConsoleLogger
		logger.Log("Error occured");
		OrderService service = new OrderService(logger);
		service.Placeorder();
	}
}