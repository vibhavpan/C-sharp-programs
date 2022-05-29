//Program to calculate the sum and avg of an array's elements

using System;

namespace program
{
	class program
	{
		public static void Main()
		{
			int[] marks=new int[] {10,20,30,40,50};
			
			Calculate(marks);
			
		}
		
		//method to calculate avg of array
		public static void Calculate(int[] array)
		{
			int size=array.Length;
			int sum=0;
			int avg=0;
			
			//loop to calcuate the sum of total marks in the array.
			
			for(int i=0;i<size;i++)
				sum+=array[i];
			
			Console.WriteLine("The sum of the marks is "+sum);
			
			//calcuate the average marks
			avg=sum/size;
			
			Console.WriteLine("The average is of the marks is "+avg);
			
		}
	}
}
