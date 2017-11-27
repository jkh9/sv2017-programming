/* 
 * Create a function named "IsInteger", which will return true if the 
 * string passed as a parameter is a valid integer number, 
 * or false otherwise.
 */

using System;

public class FunctionIsInteger
{
    public static bool IsInteger(string text)
    {
        foreach (char c in text)
        {
            if (c < '0') return false;
            if (c > '9') return false;
        }
        return true;
    }
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        string t = Console.ReadLine();
        
        
        if (IsInteger(t))
            Console.WriteLine("It is an integer number");
        else
            Console.WriteLine("It is NOT an integer number");
    }
}
