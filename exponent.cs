//program to calculate 2's power value 

using System;

class program
{
	public static void Main()
	{
		
		int e;
		int result;
		
		for(int i=0;i<11;i++)					//find exponents till power of 10
		{
			result=1;								//initialize result to 1 in each power
			e=i;										//assign e to next exponent 
		
			//multiply result with 2 till exponent value	
			
			while(e>0)				
			{
				
				result*=2;
				e--;
			}
			
			Console.WriteLine("2 to power "+i+" is "+result);
		}
	}
}
