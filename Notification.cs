using System;
using System.Collections.Generic;

public class Notification{
	public virtual void Send(){
		Console.WriteLine("sending notification");
	}
}

public class EmailNotification : Notification{
	public EmailNotification()
    {
        // safe here because Send() does not depend on extra initialization
        Send();
    }
	override public void Send(){
		Console.WriteLine("Sending Email Notification");
	}
}

public class Test{
	public static void Main(String[] args){
		List<Notification> list = new List<Notification>();
		list.Add(new EmailNotification());
		
	}
}