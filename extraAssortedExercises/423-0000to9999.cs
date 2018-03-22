// Display all the variations from 0000 to 9999 (and count them)

// Note: the answer is, obviously, 10,000

using System;

public class Combinations1
{
    public static void Main()
    {
        int count = 0;
        for (int i = 0; i <= 9999; i++)
        {
            Console.Write(i.ToString("0000") + " ");
            count ++;
        }
        
        Console.WriteLine("  Combinations found: "+count);
    }
}
