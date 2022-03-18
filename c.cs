using System;
					
public class Program
{
	public struct Number{
		double amount;
	
	public Number(double amount){
		this.amount = amount;
	}
	public void display(){
		Console.WriteLine("Salary : " + this.amount.ToString());  
	
	}	
	
 }
	public static void Main(){
		Number num = new Number(100.12);
		
	
		
		 
	
		Console.WriteLine("The number is");
		num.display();
		
		Console.ReadLine();
	}
	
}