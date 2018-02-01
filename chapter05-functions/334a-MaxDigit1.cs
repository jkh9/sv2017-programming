/*
Create a function MaxDigit to return the highest digit in a 
long integer number. (2 points):

Console.Write(MaxDigit(32)); // Should display 3

if ( MaxDigit(276) != 7 )

    Console.WriteLine("There is a bug!");
*/

// Gonzalo Martinez

using System;

public class Ex334
{
    public static byte MaxDigit(long number)
    {
        int max = number % 10;
        
        while(number > 10)
        {
            max = number % 10;
            number /= 10;
            
            if(number > max)
                max = number;
        }
        
        return max;
    }
    
    public static void Main()
    {
        Console.Write(MaxDigit(32));
        
        if(MaxDigit(276) != 7)
            Console.WriteLine("There is a bug!");
    }
}
