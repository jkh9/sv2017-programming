// Create a function named Initials, which will return the initials 
// of the string passed as a parameter. For example, if you use:
// 
// Console.Write (Initials("Primero de Dam"));
// It should display
// PDD

// Version 2: correct if there are no duplicated spaces

using System;

public class Initials2a
{
    public static string Initials(string text)
    {
        string initials="";
        initials += text[0];
        for(int i = 1; i < text.Length; i++)
        {
            if(text[i-1] == ' ')
            {
                initials += text[i];
            }
        }
        return initials.ToUpper();
    }
    
    public static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine(Initials(text));
    }
}
