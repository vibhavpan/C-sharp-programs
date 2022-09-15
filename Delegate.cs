using System;
using System.Collections.Generic;

List<string> names = new List<String>()
{
    "Vibhav",
    "Adams",
    "Ravindra"
};

//printing before removing .

Console.WriteLine("BEFORE-- \n");

foreach (string s in names)
    Console.WriteLine(s);

//pass Contains method to the predicate of Match

names.RemoveAll(Contains);

//printing after removing .

Console.WriteLine("\nAFTER-- \n");

foreach (string s in names)
    Console.WriteLine(s);

//create Method Contains that returns whether character i present in string given?
bool Contains(string s)
{
    return s.Contains("i");
}
