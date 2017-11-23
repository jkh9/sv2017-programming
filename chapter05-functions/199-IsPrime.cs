// Function IsPrime
// Guillermo Pastor

using System;

public class Ex
{
    public static bool IsPrime(long num)
    {
        long dividers = 0;

        for (long i=1; i<=num; i++)
        {
            if (num % i == 0)
                dividers++;
        }
        if (dividers == 2)
            return true;
        else
            return false;
    }
    
    public static void Main()
    {
        Console.WriteLine(IsPrime(1234567123)); 
    }
}
