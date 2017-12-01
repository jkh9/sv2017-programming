// Create a function named Initials, which will return the initials 
// of the string passed as a parameter. For example, if you use:
// 
// Console.Write (Initials("Primero de Dam"));
// It should display
// PDD

// Version 2b: correct even with duplicated spaces

using System;

public class Initials2b
{
    public static string Initials(string text)
    {
        text = text.Trim();
        string initials="";
        initials += text[0];
        for(int i = 0; i < text.Length-1; i++)
        {
            if(text[i] == ' ')
            {
                if(text[i+1] != ' ')
                {
                    initials += text[i+1];
                }
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
