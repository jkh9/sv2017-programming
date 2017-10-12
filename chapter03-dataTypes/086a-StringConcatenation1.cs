//Antonio Gas
//String + if
using System;
public class StringName
{
    public static void Main()
    {
        string name;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        if (name == "Antonio")
            Console.Write("Hello, " + name + "!");
        else
            Console.Write("I don't seem to remember you...");
    }
}
