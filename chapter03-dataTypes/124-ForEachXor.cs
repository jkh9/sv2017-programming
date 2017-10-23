// Create a C# program to ask the user for a string and display it 
// encrypted in  two different ways: first adding 1 to each char, 
// then with XOR 1

using System;

public class Xor
{
    public static void Main()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        
        foreach (char letter in name)
            Console.Write( (char) (letter+1));
        Console.WriteLine();
        
        foreach (char letter in name)
            Console.Write( (char) (letter ^ 1));
        Console.WriteLine();
    }
}
