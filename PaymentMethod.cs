using System;

abstract class PaymentMethod{
	public abstract void ProcessPayment(double amount);
}

class UPIPayment : PaymentMethod{
	public override void ProcessPayment(double amount){
		Console.WriteLine("Processing UPI payment of {0}",amount);
	}
}

class NetBankingPayment : PaymentMethod{
	public override void ProcessPayment(double amount){
		Console.WriteLine("Processing Net Banking payment of {0}",amount);
	}
}

class CardPayment : PaymentMethod{
	public override void ProcessPayment(double amount){
		Console.WriteLine("Processing Card payment of {0}",amount);
	}
}

class Test{
	public static void Main(String[] args){
		PaymentMethod pm = new UPIPayment();
		PaymentMethod pm1 = new NetBankingPayment();
		PaymentMethod pm2 = new CardPayment();
		pm.ProcessPayment(1500);
		pm1.ProcessPayment(1500);
		pm2.ProcessPayment(1500);
	}
}
