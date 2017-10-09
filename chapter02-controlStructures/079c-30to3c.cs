/*
Write a C# program to display the even numbers from 30 down to 3, only the 
multiples of 3, except 12, three times: first using "for", then "while", 
finally "do-while".
*/

// Third approach, also not valid (continue -> endless loop)

using System;

public class Ex79c
{
    public static void Main()
    {
        int i;
        
        // for (1)
        for (i = 30; i >= 3; i -= 3)
        {
            if (i == 12)
                continue;
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        // for (2)
        for (i = 30; i >= 3; i --)
        {
            if ((i == 12) || (i % 3 != 0))
                continue;
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        // while
        i = 30;
        while ( i >= 3 )
        {
            if (i == 12)
                continue;
            Console.Write("{0} ",i);
            i -= 3;
        }
        Console.WriteLine();
    }
}
