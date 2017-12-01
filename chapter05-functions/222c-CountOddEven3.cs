/*
A function to calculate the number of odd digits and even digits in a 
number. It will accept three parameters: the integer number to analyze, 
the variable to return the amount of odd digits and the variable to 
return the amount of even digits, in this order. The function should be 
named "CountOddEven". It would be used in a very similar way to:

CountOddEven (37372, odds, evens)

odds would be 4 and evens would be 1
*/

// Version 3: using only numbers + out

using System;

public class CountOddEven3
{
    public static void CountOddEven(
        int n, out int o, out int e)
    {
        o = 0;
        e = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            
            if(lastDigit % 2 == 0)
                e++;
            else 
                o++;
                
            n /= 10;
        }
    }
    
    public static void Main()
    {
        int odds, evens;
        CountOddEven (37372, out odds, out evens);
        Console.WriteLine("Odd digits: " + odds);
        Console.WriteLine("Even digits: " + evens);
    }
}
