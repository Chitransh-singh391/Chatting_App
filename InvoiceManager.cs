using System;

public class InvoiceCalculator{
	public void Calculate(InvoiceManager invoice){
		Console.WriteLine("Invoice total calculated successfully");
	}
}

public class InvoiceStore{
	public void DatabaseSave(InvoiceManager invoice){
		Console.WriteLine("Invoice saved to database");
	}
}

public class InvoicePrinter{
	public void Print(InvoiceManager invoice){
		Console.WriteLine("Invoice printed");
	}
}

public class InvoiceManager{
	public int id {get;set;}
	public double Amount {get;set;}
	
	public static void Main(){
		InvoiceManager invoice = new InvoiceManager();
		InvoiceCalculator calculator = new InvoiceCalculator();
		calculator.Calculate(invoice);
		
	}
}

