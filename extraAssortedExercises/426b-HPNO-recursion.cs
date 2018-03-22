// Display all the variations with the letters H, P, N, O, 
// maybe repeated (and count them)

using System;

public class Tema11
{
    public static void DisplayValues(string start, 
        string alphabet, int validLength)
    {
        // End: if length > 4
        if (start.Length > validLength)
            return;
        
        // Solution:  if length == 4
        if (start.Length == validLength)
            Console.Write(start+ " ");
            
        // Otherwise, keep searching
        foreach(char c in alphabet)
            DisplayValues(start+c, alphabet, validLength);
    }
    
    public static void Main()
    {
        DisplayValues("", "hpno", 4);
    }
}
