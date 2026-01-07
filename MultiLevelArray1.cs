using System;

class MultiLevelArray1{
	public static void Main(String[] args){
		int[,] arr = new int[4,4];
		Console.WriteLine("input array elements: ");
		Console.WriteLine(arr.Length);
		for(int i=0;i<arr.GetLength(0);i++){
			Console.WriteLine("input for"+ i + "line:");
			for(int j=0;j<arr.GetLength(0);j++){
				arr[i,j] = int.Parse(Console.ReadLine());
			}
		}
		
		Console.WriteLine("array is:");
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=0;j<arr.GetLength(0);j++){
				Console.Write(arr[i,j]+" ");
			}
			Console.WriteLine();
		}
		
		int median = arr.GetLength(0)/2;
		//permanent reverse a array
		for(int i=0;i<arr.GetLength(0);i++){
			Console.Write(i);
			for(int j=0;j<arr.GetLength(0)/2;j++){
				int temp = arr[i,j];
			    arr[i,j] = arr[i,arr.GetLength(0) - 1  - j];
			    arr[i,arr.GetLength(0) - 1  - j] = temp;

			}
			
		}
		Console.WriteLine();
		
		Console.WriteLine("array is:");
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=0;j<arr.GetLength(0);j++){
				Console.Write(arr[i,j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine();
		
		//traversing using foreach loop
		foreach(int value in arr){
			Console.Write(value+" ");
			
		}
		
		Console.WriteLine();
		
		int[,] copyArray = (int[,])arr.Clone();
		foreach(int value in copyArray){
			Console.Write(value+" ");
			
		}
		
		Console.WriteLine();
		int[,] trans = new int[4,4]; 
		//transpose matrix only 2d
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=0;j<arr.GetLength(1);j++){
				trans[j,i] = arr[i,j];
			}
			
		}
		Console.WriteLine("after transpose array is:");
		for(int i=0;i<trans.GetLength(0);i++){
			for(int j=0;j<trans.GetLength(1);j++){
				Console.Write(trans[i,j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine(); 
		
		//in-place transpose means transpose in the same array 
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=i+1;j<arr.GetLength(1);j++){
				int temp = arr[i,j];
				arr[i,j] = arr[j,i];
				arr[j,i] = temp;
			}
		}
		
		Console.WriteLine("after in-place transpose array is:");
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=0;j<arr.GetLength(1);j++){
				Console.Write(arr[i,j]+" ");
			}
			Console.WriteLine();
		}
		
		
		int[,] arr2 = new int[4,4];
		Console.WriteLine("input array elements: ");
		
		for(int i=0;i<arr2.GetLength(0);i++){
			Console.WriteLine("input for"+ i + "line:");
			for(int j=0;j<arr2.GetLength(1);j++){
				arr2[i,j] = int.Parse(Console.ReadLine());
			}
		}
		
		Console.WriteLine(" other array is:");
		for(int i=0;i<arr2.GetLength(0);i++){
			for(int j=0;j<arr2.GetLength(1);j++){
				Console.Write(arr2[i,j]+" ");
			}
			Console.WriteLine();
		}
		
		int[,] mulArr = new int[4,4];
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=0;j<arr2.GetLength(1);j++){
				mulArr[i,j] = arr[i,j] * arr2[i,j];
			}
		}
		
		Console.WriteLine("after multiplication array is:");
		for(int i=0;i<mulArr.GetLength(0);i++){
			for(int j=0;j<mulArr.GetLength(1);j++){
				Console.Write(mulArr[i,j]+" ");
			}
			Console.WriteLine();
		}
		
		
	
		
	}
}