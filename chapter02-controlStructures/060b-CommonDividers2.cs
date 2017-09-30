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
        
        int min;
        if (n2 < n1)
            min = n2;
        else
            min = n1;
        
        Console.Write("Their common dividers are ");
        for(int i = 1; i < min; i++)
        {
            if ((n1 % i == 0) && (n2 % i == 0))
                Console.Write("{0} ", i);
        }
        
    }
}
