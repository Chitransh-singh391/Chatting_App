using System;
using System.Linq;

class JaggedArray{
	public static void Main(String[] args){
		int[][] JaggedArr1 = new int[3][];
		
		Console.WriteLine("input array elements: ");
		int cols;
		for(int i=0;i<3;i++){
			
			Console.WriteLine("enter row "+(i+1)+"length: ");
			cols = int.Parse(Console.ReadLine());
			JaggedArr1[i] = new int[cols];
			Console.WriteLine("input for"+ (i+1) + "line:");
			for(int j=0;j<cols;j++){
				JaggedArr1[i][j] = int.Parse(Console.ReadLine());
			}
		}
		
		Console.WriteLine(" other array is:");
		for(int i=0;i<3;i++){
			for(int j=0;j<JaggedArr1[i].Length;j++){
				Console.Write(JaggedArr1[i][j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine();
		
		foreach(var i in JaggedArr1){
			foreach(var j in i){
				Console.Write(j+" ");
			}
			Console.WriteLine();
			
		}
		
		Console.WriteLine(JaggedArr1.Length);
		//check that array has element or not
		bool exists = JaggedArr1.Any(r => r.Contains(5));
		Console.WriteLine(exists);
		
		//copy jagged array
		int[][] copyJaggedArr = (int[][])JaggedArr1.Clone();
		
		Console.WriteLine("copied array is:");
		
		foreach(var i in copyJaggedArr){
			foreach(var j in i){
				Console.Write(j+" ");
			}
			Console.WriteLine();
		}
		
		//Sorting of array is:-
		//for(int k=0;k<copyJaggedArr.Length;k++){
		//	Array.Sort(copyJaggedArr[k]);
		//}
		
		Array.Sort(copyJaggedArr , (x,y)=>x.Length.CompareTo(y.Length));
		
		Console.WriteLine("After sorting : ");
		for(int i=0;i<3;i++){
			for(int j=0;j<copyJaggedArr[i].Length;j++){
				Console.Write(copyJaggedArr[i][j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine();
		
		//Add new row(resize outer array)
		Array.Resize(ref copyJaggedArr,copyJaggedArr.Length+1);
		copyJaggedArr[copyJaggedArr.Length-1] = new int[]{10,20};
		Console.WriteLine("After adding new row: ");
		for(int i=0;i<4;i++){
			for(int j=0;j<copyJaggedArr[i].Length;j++){
				Console.Write(copyJaggedArr[i][j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine();
		
		//Add new element in the existing row
		int[] row = copyJaggedArr[0];
		Array.Resize(ref row, row.Length+1);
		row[row.Length-1] = 99;
		copyJaggedArr[0] = row;
		
		Console.WriteLine("After adding new element in the row: ");
		for(int i=0;i<4;i++){
			for(int j=0;j<copyJaggedArr[i].Length;j++){
				Console.Write(copyJaggedArr[i][j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine();
		
		//delete a row
		copyJaggedArr = copyJaggedArr.Where((r,index)=> index != 2).ToArray();
		Console.WriteLine("After deleting the row: ");
		for(int i=0;i<3;i++){
			for(int j=0;j<copyJaggedArr[i].Length;j++){
				Console.Write(copyJaggedArr[i][j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine();
		
		int total = copyJaggedArr.Sum(r=>r.Sum());
		Console.WriteLine("total sum: "+total);
		Console.WriteLine();
		
		int min = copyJaggedArr.Min(r=>r.Min());
		int max = copyJaggedArr.Max(r=>r.Max());
		
		Console.WriteLine("min and max : "+min +" "+max);
		
		
		//in jagged array transpose can slao be perform
		//if and only if the all rows length are equal
		
		//below is the code:- 
		//int rows = a.length;
		//int cols = a[0].Length;
		//int[][] t= new int[cols][];
		//for(int i=0;i<cols;i++){
		//	t[i] = new int[rows];
		//	for(int j=0;j<rows;j++){
		//		t[i][j] = a[j][i];
		//	}
		//}
		

		

	}
}