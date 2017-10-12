//
// Miguel Puerta
// Greeting the user (contact with "string")
//

using System;

public class Ex84
{
    public static void Main()
    {
        string name;
        
        Console.Write("Write your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hi {0}", name);
    }
}  
