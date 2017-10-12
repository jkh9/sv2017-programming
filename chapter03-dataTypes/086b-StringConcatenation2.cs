//Antonio Gas
//String + if
using System;
public class StringName
{
    public static void Main()
    {
        string name, greeting;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        
        if (name == "Antonio")
            greeting = "Hello, " + name + "!";
        else
            greeting = "I don't seem to remember you...";
            
        Console.Write(greeting);
    }
}
