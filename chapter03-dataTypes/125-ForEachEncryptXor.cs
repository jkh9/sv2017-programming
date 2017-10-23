// Create a C# program to ask the user for a string and display 
// it encrypted and then decrypted again, using XOR

using System;

public class XorString
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string name = Console.ReadLine();
        
        string encrypted = "";
        foreach (char letter in name)
            encrypted += (char) (letter ^ 5);
        Console.WriteLine( encrypted );
        
        string decrypted = "";
        foreach (char letter in encrypted)
            decrypted += (char) (letter ^ 5);
        Console.WriteLine( decrypted );
    }
}
