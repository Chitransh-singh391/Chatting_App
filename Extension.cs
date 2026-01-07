using System;

public static class Extension{
	public static int Wordcount(this string str){
		if(string.IsNullOrWhiteSpace(str)){
			return 0;
		}
		return str.Split(' ').Length;
	}
}

public class Test{
	public static void Main(){
		string str = "Hello World , i am chitransh singh badgurjar";
		int count = str.Wordcount();
		Console.WriteLine(count);
	}
}