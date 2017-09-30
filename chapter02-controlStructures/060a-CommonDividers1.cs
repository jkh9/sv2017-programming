// Common dividers of two numbers

using System;

public class CommonDividers
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Their common dividers are ");
        
        // TO DO: Find the minimum
        for(int i = 1; i < n1; i++)
        {
            if ((n1 % i == 0) && (n2 % i == 0))
                Console.Write("{0} ", i);
        }
        
    }
}
