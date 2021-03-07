using System;
using System.Collections.Generic;
					
public class Program{
	public static void Main(){
		/*
		Console.WriteLine("Сколько вам лет?");
		int age = Console.ToInt32(Console.ReadLine());
		
		//string s_age = Convert.ToString(age);
		
		Console.WriteLine("Ваш возраст: " + age);
		
		if (age > 18){
			Console.WriteLine(" Вы большой!");
		}
		*/
		
		var arr = new List<int>{0,1,2,3,4,5,6,7};
		
		foreach(int num in arr){
			Console.WriteLine(num);
		}
	}
}