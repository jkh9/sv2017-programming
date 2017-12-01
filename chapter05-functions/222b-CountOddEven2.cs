/*
A function to calculate the number of odd digits and even digits in a 
number. It will accept three parameters: the integer number to analyze, 
the variable to return the amount of odd digits and the variable to 
return the amount of even digits, in this order. The function should be 
named "CountOddEven". It would be used in a very similar way to:

CountOddEven (37372, odds, evens)

odds would be 4 and evens would be 1
*/

// Version 2: using only numbers

using System;

public class CountOddEven2
{
    public static void CountOddEven(
        int n, ref int o, ref int e)
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
        int odds = 0;
        int evens = 0;
        CountOddEven (37372, ref odds, ref evens);
        Console.WriteLine("Odd digits: " + odds);
        Console.WriteLine("Even digits: " + evens);
    }
}
