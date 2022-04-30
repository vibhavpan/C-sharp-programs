//C# program to calculate length of friend names entered.

using System;

namespace demo
{
	class demo
		{
			public static void Main()
			{
				int length=0;
				string name="";
				
				int totalLength=0;
				
				string friendName="";
				
				//do while to take number of friends name as input
				
				do
				{
					Console.WriteLine("Please enter the name of your friend ");
					name=Console.ReadLine();
					
					length=name.Length;		//read legnth of friend name
					totalLength+=length;
					
					friendName+=name;			//name all the friends
					
				}while(totalLength<20);		//if friendName Length<20
			
				Console.WriteLine("Thanks you're friends name was "+friendName);
				Console.WriteLine("Total length is "+friendName.Length);
			}
		}
}
