// Create a C# program to ask the user for a string 
// and display it encrypted an then decrypted again, using 
// XOR and a constant for the key

using System;

public class EncryptSumConst
{
    public static void Main()
    {
        const int KEY = 4;
        
        Console.Write("Enter a sentence: ");
        string name = Console.ReadLine();
        
        string encrypted = "";
        foreach (char letter in name)
            encrypted += (char) (letter ^ KEY);
        Console.WriteLine( encrypted );
        
        string decrypted = "";
        foreach (char letter in encrypted)
            decrypted += (char) (letter ^ KEY);
        Console.WriteLine( decrypted );
    }
}
