// Function Reverse, recursive version
// Javier Cases Sempere

using System;

public class Ex220
{
    public static string Reverse(string text)
    {
        // Base case: 1 letter or empty string -> as is
        if (text.Length <= 1)
            return text;
        // General case: last letter + previous n-1 reversed
        return text.Substring(text.Length - 1, 1) + 
            Reverse(text.Substring(0, text.Length - 1));
    }

    public static void Main()
    {
        string text = "Hola";
        Console.WriteLine(Reverse(text));
    }
}

