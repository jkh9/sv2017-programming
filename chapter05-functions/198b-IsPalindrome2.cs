//Guillermo Pastor
using System;
using System.Linq;
public class Ex198
{
    public static bool IsPalindrome(string name)
    {
        string reverse = new string (name.Reverse().ToArray());
        if (reverse == name)
        {
            return true;
        }
        else
        {
            return false;
        }        
    }
    
    public static void Main()
    {
        Console.WriteLine(IsPalindrome("abcdcba")); 
    }
}
