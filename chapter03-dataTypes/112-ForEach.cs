// Contact with "fireach"
// Jose Vilaplana

using System;

public class FirstForEach
{
    public static void Main()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        foreach (char letter in name)
        {
            Console.Write(letter);
            Console.Write(" ");
        }
        Console.WriteLine();
        
        foreach (char letter in name)
            Console.Write(letter + " ");
        Console.WriteLine();
        
        foreach (char letter in name)
            Console.Write("{0} ", letter);
        Console.WriteLine();
    }
}
