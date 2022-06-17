//C# program to use dictionary

using System.Collections.Generic;
using System;
using System.Linq;

class program
{
	public static void Main()
	{
		//creating array of employees
		Employee[] employees={
			
			new Employee("CEO","Vibhav",30,10000),
			new Employee("Manager","Ron",40,1222),
			new Employee("Programer","hary",50,1000),
		};
		
		//creating Dictionary of type string key and Employee value 
		Dictionary<string,Employee> myEmployees=new Dictionary<string,Employee>();
		
		//adding new members from the array
		foreach(Employee emp in employees)
		{
			myEmployees.Add(emp.Role,emp);
		}
		
		//updating value of employee who is Manager
		
		string keyToUpdate="Manager";
		
		if(myEmployees.ContainsKey(keyToUpdate))
		{
			myEmployees[keyToUpdate]=new Employee("Manager","Vibhav",20,20000);
			
			Console.WriteLine("Role {0} is updated ",keyToUpdate);
			
		}
		
		else
			Console.WriteLine("Role {0} is not found ",keyToUpdate);
			
		
		//removing value of employee who is Manager
		
		string toRemove="Manager";
		
		if(myEmployees.Remove(toRemove))
			Console.WriteLine("Role {0} removed ",toRemove);
		
		else
			Console.WriteLine("No one with role {0} was found ",toRemove);
		
		
		//finding the data's of the employee who are Manager
		
		bool l=myEmployees.ContainsKey("Manager");
		Employee result;
		
		if(myEmployees.TryGetValue("Manager",out result))
		{
			Employee emp1=myEmployees["Manager"];
			Console.WriteLine(emp1);
		}
		
		Console.WriteLine(result);
		
		//check if Manager post is present or not
		
		if(myEmployees.TryGetValue("Manager",out result))
		{
			Console.WriteLine("Value retrieved ");
			
			Console.WriteLine("{0}",result.Name);
			Console.WriteLine("{0}",result.Age);
			Console.WriteLine("{0}",result.Rate);
		}
		
		else
			Console.WriteLine("Key does not existe ");
		
    //check if CEO post is present or not
		/*
		if(myEmployees.ContainsKey("CEO"))
		{
			Console.WriteLine("Value retrieved ");
			
			Console.WriteLine("{0}",result.Name);
			Console.WriteLine("{0}",result.Age);
			Console.WriteLine("{0}",result.Rate);
		}
		
		else
			Console.WriteLine("Value not retrieved ");
		*/
		/*
    
    //making keyValuePair
		for(int i=0;i<myEmployees.Count;i++)
		{
			KeyValuePair<string,Employee> keyValuePair=myEmployees.ElementAt(i);
			
			Console.WriteLine("key is {0} and i value is {1}",keyValuePair.Key,i++);
			
			Employee keyPair=keyValuePair.Value;
			
			//printing values of keyValuePair
			Console.WriteLine("Employee name {0} ",keyPair.Name);
			Console.WriteLine("Employee name {0} ",keyPair.Role);
			Console.WriteLine("Employee name {0} ",keyPair.Age);
			Console.WriteLine("Employee name {0} ",keyPair.Salary);
	
		}	
			*/
	
	}
}

//creating class Employee with getters and setters

class Employee
{

 
	public string Role{set;get;}
	public string Name{set;get;}
	public int Age{set;get;}
	public float Rate{set;get;}

//setter and getter for salary
	public float Salary
	{
			get
		{
			return Rate*8*5*4*12;
		}
	}
	
	public Employee(string Role,string Name,float Rate,int Age)
	{
		this.Role=Role;
		this.Name=Name;
		this.Age=Age;
		this.Rate=Rate;
	}
	
}
