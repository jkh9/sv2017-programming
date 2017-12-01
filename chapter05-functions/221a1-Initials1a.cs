// Create a function named Initials, which will return the initials 
// of the string passed as a parameter. For example, if you use:
// 
// Console.Write (Initials("Primero de Dam"));
// It should display
// PDD

// Version 1a: correct if there are no duplicated spaces

using System;

public class Initials1
{
    public static string Initials(string text)
    {
        string[] fragments = text.Split();
        string initials = "";
        
        for (int i = 0; i < fragments.Length; i++)
        {
            initials += fragments[i].Substring(0,1);
        }
        return initials.ToUpper();
    }
    
    public static void Main()
    {
        Console.Write(Initials("Primero de DAM"));
    }
}
