using System;

class BankAccount{
	private string HolderName;
	private string AccountNumber;
	private double Balance; 
	
	public string holderName
	{   get{
		    return HolderName;
	    }
	    set{
		    HolderName = value;
	    }
	}
	
	public string accountNumber
	{
		get{
			return AccountNumber;
		} 
		private set{
			AccountNumber = value;
		}
	}
	
    public double balance
    {
        get
        {
            return Balance;
        }
        private set
		
        {
            Balance = value;
        }
    }
	
	
	public BankAccount(string HolderName,string AccountNumber,double initialbalance){
		if(string.IsNullOrWhiteSpace(HolderName) || string.IsNullOrWhiteSpace(AccountNumber) || initialbalance<0){
			throw new ArgumentException("user information cannot fill with empty values and balance should be greater than 0.");
		}
		holderName = HolderName;
		accountNumber = AccountNumber;
		balance = initialbalance;
	}
	
	public void Deposit(int amount){
		if(amount >0){
			balance += amount;
			Console.WriteLine("Balance after deposit: "+balance);
		}
		else{
			Console.WriteLine("deposit a valid amount");
		}
	}
	
	public void Withdraw(int amount){
		if(amount>0 && amount<balance){
			balance -= amount;
			Console.WriteLine("Balance after withdrawal: "+balance);
		}
		else{
			Console.WriteLine("Insufficient balance");
		}
	}
}

class Test{
	public static void Main(String[] args){
		try{
			BankAccount b1 = new BankAccount("piyush","A3472HCHG22",0);
			b1.holderName="herish";
		    b1.Deposit(5000);
		    b1.Withdraw(2000);
		    b1.Withdraw(4000);
		}
		catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
	
}
}


