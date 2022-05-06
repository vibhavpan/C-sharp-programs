//C# program to print name

using System;

namespace program
{
	class Human
	{
		private string firstName;
		private string lastName;
		
		private string eyeColor;
		private int age=0;
		
		public Human()
		{
			Console.WriteLine("Hi there ,I am from basic constructor ");
		}
		
		
		//constructor of Human class
		
		public Human(string firstName,string lastName,string eyeColor,int age)
		{
			//assign the member var to new value
			
			this.firstName=firstName;	
			this.lastName=lastName;
			
			this.age=age;
			this.eyeColor=eyeColor;
			
		}
		
		public Human(string eyeColor,int age)
		{
			this.eyeColor=eyeColor;
			this.age=age;
		}
		
		public Human(string firstName,string eyeColor)
		{
			this.firstName=firstName;
			this.eyeColor=eyeColor;
		}
		
		//constructor for name
		public Human(string fName)
		{
			firstName=fName;
		}
		
		//constructor for age
		
		public Human(int age)
		{
			this.age=age;
		}
		
		//method for printing info
		public void IntroduceMyself()
		{
			Console.WriteLine("Hello my name is "+firstName+" "+lastName);
			
			//check for nulls or not
			
			if(age!=0 & lastName!=null & firstName!=null & eyeColor!=null )					
				Console.WriteLine("My age is "+age+" yr my eye color is "+eyeColor);
			
			 if(firstName!=null)
				Console.WriteLine("My first name is "+firstName);
			
			 if (firstName!=null && eyeColor!=null)
				
				{
					Console.WriteLine("My first name is {0} and eye color is {1}",firstName,eyeColor);
				}
			 if(eyeColor!=null)
				Console.WriteLine("My eye color is "+eyeColor);
		}	
			
	}
	
	class program
	{
		
		public static void Main()
		
		{
			//creating first object of Human
			
			Human vibhav=new Human("vibhav","pandey","blue",1);      
			vibhav.IntroduceMyself();	
				
			Human basicHuman=new Human("Neeraj","Blue");
			basicHuman.IntroduceMyself();
			
			
		}
	}
}

			
