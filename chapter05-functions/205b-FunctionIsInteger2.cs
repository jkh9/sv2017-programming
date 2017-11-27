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
            switch(c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': break;
                default: return false;
            }
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
