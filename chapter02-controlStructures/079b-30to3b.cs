/*
Write a C# program to display the even numbers from 30 down to 3, only the 
multiples of 3, except 12, three times: first using "for", then "while", 
finally "do-while".
*/

// Second approach, also not valid (not real loops)

using System;

public class Ex79b
{
    public static void Main()
    {
        for (int i = 1; i <= 1; i ++)
            Console.WriteLine("30 27 24 21 18 15 09 06 03");
            
        int j = 0;
        while ( j < 1 )
        {
            Console.WriteLine("30 27 24 21 18 15 09 06 03");
            j++;
        }
        
        j = 0;
        do
        {
            Console.WriteLine("30 27 24 21 18 15 09 06 03");
            j++;
        }
        while ( j < 1 );
    }
}
