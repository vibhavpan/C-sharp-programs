using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Please enter an option 1)->List  2)->Queue 3)->Array");
		
		string option1=Console.ReadLine();
		
		int option=Int32.Parse(option1);
		
    //create an ienumerable list
		IEnumerable<int> unknownCollection;
		unknownCollection=GetCollection(option);
		
    //based on option IEnumerable collection will be assigned to list,queue,array and will print it.
		switch(option)
		{
			case 1:
				Console.WriteLine("For List");
				foreach(int num in unknownCollection)
					Console.Write("{0}\t",num);
					
				break;
		
			case 2:
				Console.WriteLine("For Queue");
				foreach(int num in unknownCollection)
					Console.Write("{0}\t",num);
					
				break;
			
			
			case 3:
				Console.WriteLine("For Array");
				foreach(int num in unknownCollection)
					Console.Write("{0}\t",num);
					
				break;
		}
	}
	
	static IEnumerable<int> GetCollection(int option)
	{
		List<int> numbersList=new List<int>()	{1,2,3,4,5};
		//create a generic Queue
		Queue<int> numbersQueue=new Queue<int>();
		
    //add elements to it
		numbersQueue.Enqueue(6);
		numbersQueue.Enqueue(7);
		numbersQueue.Enqueue(8);
		numbersQueue.Enqueue(9);
		numbersQueue.Enqueue(10);
		
    //if option==1 return list
		if(option==1)
			return numbersList;
		
    //if option==2 return queue
		else if(option==2)
			return numbersQueue;
		
    //else return array
		else
			return new int[] {11,12,13,14,15};
	}
}
