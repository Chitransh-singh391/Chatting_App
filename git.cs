using System;
using System.Linq;

class ArrayExample{
	static void Main(String[] args){
		int[] arr = new int[5];
		Console.WriteLine("input Array element: ");
		for(int i=0;i<arr.Length;i++){
			arr[i] = int.Parse(Console.ReadLine());
		}
		
		Console.Write("array is: ");
		for(int i=0;i<arr.Length;i++){
			Console.Write(arr[i]+ " ");
		}
		
		Console.WriteLine("element: "+arr[0]);
		arr[0] = 7;
		Console.WriteLine("element: "+arr[0]);
		
		foreach(int i in arr){
			Console.WriteLine("element: "+i);
		}
		
		//reverse array without using built-in method
		Console.WriteLine("reversed array : ");
		for(int i=0;i<arr.Length;i++){
			Console.Write(arr[(arr.Length-1)-i]+" ");
		}
		Console.WriteLine();
		//found element index
		Console.Write(Array.IndexOf(arr,4) + Array.IndexOf(arr,9));
		Console.WriteLine();
		
		//copy a array
		int[] b = new int[arr.Length];
		Array.Copy(arr,b,arr.Length);
		Console.Write("copy array is: ");
		for(int i=0;i<b.Length;i++){
			Console.Write(b[i]+ " ");
		}
		Console.WriteLine();
		
		//Cloning array
		int[] c = (int[])b.Clone();
		Console.Write("cloning array is: ");
		for(int i=0;i<c.Length;i++){
			Console.Write(c[i]+ " ");
		}
		
		int median = c.Length/2;
		//permanent reverse a array
		for(int i=0;i<c.Length/2;i++){
			
		    int temp = c[i];
			c[i] = c[c.Length - 1  - i];
			c[c.Length - 1 - i] = temp;
			
		}
		Console.WriteLine();
		
		Console.WriteLine("reversed array : ");
		for(int i=0;i<c.Length;i++){
			Console.Write(c[i]+" ");
		}
		
		Console.WriteLine();
		
		//Resize array
		Array.Resize(ref c,10);
		for(int i=0;i<c.Length;i++){
			Console.Write(c[i]+" ");
		}
		Console.WriteLine();
		int max = c.Max();
		int sum = c.Sum();
		Console.WriteLine(max);
		Console.WriteLine(sum);
		Console.WriteLine();
		
		//clear array element :- output :- 0 0 0 0 0
		Array.Clear(c,0,c.Length);
		for(int i=0;i<c.Length;i++){
			Console.Write(c[i]+" ");
		}
		
	}
}