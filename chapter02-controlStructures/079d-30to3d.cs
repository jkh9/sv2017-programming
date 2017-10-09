/*
Write a C# program to display the even numbers from 30 down to 3, only the 
multiples of 3, except 12, three times: first using "for", then "while", 
finally "do-while".
*/

// Forth approach, valir

using System;

public class Ex79d
{
    public static void Main()
    {
        int i;
        
        // for (1)
        for (i = 30; i >= 3; i -= 3)
            if (i != 12)
                Console.Write("{0} ",i);
        Console.WriteLine();
        
        // for (2, not necessary and slower)
        for (i = 30; i >= 3; i --)
        {
            if ((i != 12) && (i % 3 == 0))
                Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        // while
        i = 30;
        while ( i >= 3 )
        {
            if (i != 12)
                Console.Write("{0} ",i);
            i -= 3;
        }
        Console.WriteLine();
        
        // do - while
        i = 30;
        do
        {
            if (i != 12)
                Console.Write("{0} ",i);
            i -= 3;
        }
        while ( i >= 3 );
        Console.WriteLine();
    }
}
