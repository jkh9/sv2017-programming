// Ask the user for a "char" in the range 0 to 9 and display its numerical value 
// using Convert.ToInt32 (you will obtain its ASCII code).
//
// Find at least one way to get its numerical value (1 for '1', instead of 49).
//
// Also, display the chars corresponding to the numbers 32 to 127.

//Miguel García Gil

using System;

public class NumericValueOfChar
{
    public static void Main ()
    {
        char letter;
        
        Console.Write("Enter a letter: ");
        letter = Convert.ToChar (Console.ReadLine());
        
        Console.Write("ASCII: ");
        Console.WriteLine(Convert.ToByte(letter));
        
        Console.Write("Numeric value (1): ");
        Console.WriteLine(Convert.ToByte(letter)-48);
        
        Console.Write("Numeric value (2): ");
        Console.WriteLine(Convert.ToByte(letter-'0'));
        
        Console.Write("Numeric value (3): ");
        Console.WriteLine(Convert.ToByte(
            Convert.ToString(letter)));
            
        Console.Write("Numeric value (4): ");
        Console.WriteLine(Convert.ToByte(""+letter));
        
        for(byte i=32; i<=127; i++)
            Console.Write( (char) i );
        
    }
}
