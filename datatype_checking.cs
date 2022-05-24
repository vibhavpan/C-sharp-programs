//program to verify data type value entered by user 

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
		
        public static void Main()
        {	
				bool retValue=true;

				//Read in the input value from user
				
				Console.WriteLine("Please enter a statement ");
				String i_p=Console.ReadLine();
				
				//ask for approx data type
				Console.WriteLine("Please enter the type of data type you think you entered ");
				
				Console.WriteLine("1)Int\n2)String\n3)Boolean");
				String ans=Console.ReadLine();
				
				switch(ans)
				{
					case "1":
						
						int I;
						
						//check for integer value compatibility
						Boolean b=int.TryParse(i_p,out I);
						
						if(b)
							Console.WriteLine(I+" is integer ");
						
						else
							Console.WriteLine("is not an integer ");
						
						break;
					
					//for string
					case "2":
					
						//loop to check whether string or not
						
						foreach(char c in i_p)
						{
							if(!char.IsLetter(c))
								retValue=false;
							else
								retValue=true;
						}
						
						//if string
						if(retValue)
							Console.WriteLine(i_p+" Yes is string ");
						
						else
							Console.WriteLine(i_p+" Is not a string ");
						
						break;
						
					//boolean
					case "3":
						
						//check for boolean comaptibilty
						retValue=bool.TryParse(i_p,out retValue);
						
						if(retValue)
							Console.WriteLine(i_p+" is boolean ");
						
						else
							Console.WriteLine(i_p+" is not boolean ");
						
						break;
							
							
						
				}
				
            
        }
        
    }
}
