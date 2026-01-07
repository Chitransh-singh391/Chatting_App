using System;

class Employee{
	virtual public void CalculateSalary(){
		Console.WriteLine("Employee salary: ");
	}
}

class PermanentEmployee : Employee{
	private double salary = 50000;
	
	public override void CalculateSalary(){
		Console.WriteLine("Permanent Employee salary: "+salary);
	}
}
class Test{
	public static void Main(String[] args){
	    Employee emp = new PermanentEmployee();
	    
	    emp.CalculateSalary();
    }  

}

