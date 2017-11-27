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
        string valid = "0123456789";
        
        foreach (char c in text)
        {
            if ( ! valid.Contains(c) ) return false;
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
