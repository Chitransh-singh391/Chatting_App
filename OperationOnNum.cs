using System;

class OperationOnNum{
	
	public void fibo_series(int num){
		int n1=0 , n2=1 ,n3;
		for(int i=0;i<num;i++){
			Console.Write(n1+" ");
			n3 = n1 + n2;
			n1 = n2;
			n2 = n3;		
		}
	}
	
	public int factorial(int n){
		if(n==1 || n==0){
			return 1;
		}
		return n*factorial(n-1);
	}
	
	public int gcd(int n1,int n2,int i){
		if (i > Math.Min(n1, n2)){
            return 1;
		}
	
		if(n1%i == 0 && n2%i==0){
			return i;
		}
		return gcd(n1,n2,++i) ;
	}
	
	public int check_palindrome(int n,int sum){
		if(n==0){
			return sum;
		}
		int r = n%10;
		sum = sum*10+r;
		n = n/10;
		
		return check_palindrome(n, sum);
	}
	
	public int check_armstrong(int n,int sum){
		if(n==0){
			return sum;
		}
		int r = n%10;
		sum = sum + (int)Math.Pow(r,3);
		n = n/10;
		
		return check_armstrong(n, sum);
	}
	
	public int check_prime(int n,int fact,int i){
		if(i > n/2){
			return fact;
		}
		if(n%i == 0){
			fact=1;
			return fact;
		}
		return check_prime(n,fact,++i);
	}
	
	public int check_perfect(int n,int sum,int i){
		if(i==n){
			return sum;
		}
		if(n%i == 0){
			sum+=i;
		}
		
		return check_perfect(n, sum,++i);
	}
	
	
	
	
	public static void Main(String[] args){
		
		Console.WriteLine("enter length of fibonacci series: ");
		int num = int.Parse(Console.ReadLine());
		OperationOnNum obj1 = new OperationOnNum();
		Console.Write("fibonacci series is : ");
		obj1.fibo_series(num);
		Console.WriteLine();
		Console.Write("factorial is: " + obj1.factorial(num));
		Console.WriteLine();
		Console.WriteLine("enter another number: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.Write("gcd is: "+obj1.gcd(num,num2,2));
		
		Console.WriteLine();
		Console.WriteLine("enter number to check palindrome or not: ");
		int num3 = int.Parse(Console.ReadLine()); //12321
		int temp = num3;
		if(obj1.check_palindrome(num3,0) == temp){
			Console.Write("palindrome number");
		}
		else{
			Console.Write("not palindrome number");
		}
		
		Console.WriteLine();
		Console.WriteLine("enter number to check armstrong or not: ");
		int num4 = int.Parse(Console.ReadLine()); 
		int temp1 = num4;
		if(obj1.check_armstrong(num4,0) == temp1){
			Console.Write("armstrong number");
		}
		else{
			Console.Write("not armstrong number");
		}
		
		Console.WriteLine();
		Console.WriteLine("enter number to check prime or not: ");
		int num5 = int.Parse(Console.ReadLine());
		int fact =0;
		if(obj1.check_prime(num5,fact,2) == fact){
			Console.Write("prime number");
		}
		else{
			Console.Write("not prime number");
		}
		
		Console.WriteLine();
		Console.WriteLine("enter number to check perfect or not: ");
		int num6 = int.Parse(Console.ReadLine());
		if(obj1.check_perfect(num6,0,1) == num6){
			Console.Write("perfect number");
		}
		else{
			Console.Write("not perfect number");
		}
		
		Console.WriteLine();
		Console.WriteLine(5 >> 1); //right shift
		Console.WriteLine(5 << 1); //left shift
		


        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        // Bitwise NOT
        Console.WriteLine("Bitwise NOT: " + (~n));

        Console.WriteLine("Enter a decimal number:");
        double d = double.Parse(Console.ReadLine());

        Console.WriteLine("Round: " + Math.Round(d));
        Console.WriteLine("Ceiling: " + Math.Ceiling(d));
        Console.WriteLine("Floor: " + Math.Floor(d));

        Console.Write(d++ + ++d);

	}
}y