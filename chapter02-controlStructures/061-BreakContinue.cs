/*  
 
 Write a program to display the numbers 1 to 5, first interrupting before 3 
 with "break" and then skipping 3 with "continue" 
 
 Brandon Blasco Del CID

*/
using System;

public class Ex061a
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++ )
        {
            if (i == 3)
                break;
            Console.Write(i);
        }
        Console.WriteLine();
        
        for (int i = 1; i <= 5; i++ )
        {
            if (i == 3) 
                continue;
            Console.Write(i);
        }
        Console.WriteLine();
    }
}
