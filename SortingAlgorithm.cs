using System;

class SortingAlgorithm{
	public void Bubble_sort<T>(T[] arr)where T : IComparable<T>{
		for(int i=0;i<arr.Length;i++){
			for(int j=0;j<arr.Length-i-1;j++){
				if(arr[j].CompareTo( arr[j+1])>0){
					T temp = arr[j];
					arr[j] = arr[j+1];
					arr[j+1] = temp;
				}
				
			}
		}
	}
	
	public void selection_sort<T>(T[] arr)where T : IComparable<T>{
		for(int i=0;i<arr.Length-1;i++){
			int minIndex = i;
			for(int j=i+1;j<arr.Length;j++){
				if(arr[j].CompareTo( arr[minIndex])<0){
					minIndex = j;
				}
			}
			T temp = arr[i];
			arr[i] = arr[minIndex];
			arr[minIndex] = temp;
		}
	}
	
	public void Insertion_sort<T>(T[] arr)where T : IComparable<T>{
		for(int i=1;i<arr.Length;i++){
			T key = arr[i];
			int j = i-1;
			while(j>=0 && (arr[j].CompareTo(key)>0)){
				arr[j+1] = arr[j];
				j--;
			}
			arr[j+1] = key;
		}
	}
	
	//divide and conquer method for sorting
    public void Merge_sort<T>(T[] arr) where T : IComparable<T>
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;

        // Divide
        T[] left = new T[mid];
        T[] right = new T[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        // Conquer
        Merge_sort(left);
        Merge_sort(right);

        // Merge
        Merge(arr, left, right);
    }

    private void Merge<T>(T[] arr, T[] left, T[] right) where T : IComparable<T>
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i].CompareTo(right[j]) <= 0)
            {
                arr[k++] = left[i++];
            }
            else
            {
                arr[k++] = right[j++];
            }
        }

        // Copy remaining elements
        while (i < left.Length)
            arr[k++] = left[i++];

        while (j < right.Length)
            arr[k++] = right[j++];
    }

    public void quick_sort<T>(T[] arr)where T : IComparable<T>{
		
	}

    

	
	public void printArr<T>(T[] arr)where T : IComparable<T> {
		for(int i=0;i<arr.Length;i++){
			Console.Write(arr[i]+" ");
		}
	}
	
	public static void Main(){
		int[] arr1 = {7,4,1,8,23,43,12,46,5,2,67};
		SortingAlgorithm s1 = new SortingAlgorithm();
		Console.WriteLine("Bubble sort:");
		s1.Bubble_sort(arr1);
		s1.printArr(arr1);
		
		Console.WriteLine();
		Console.WriteLine("Selection sort:");
		s1.selection_sort(arr1);
		s1.printArr(arr1);
		
		Console.WriteLine();
		Console.WriteLine("Insertion sort:");
		s1.Insertion_sort(arr1);
		s1.printArr(arr1);
		
		Console.WriteLine();
		Console.WriteLine("Merge sort:");
		s1.Merge_sort(arr1);
		s1.printArr(arr1);
	}
}