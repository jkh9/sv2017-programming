/*
Function IsHappyNumber


A happy number (http://en.wikipedia.org/wiki/Happy_number) is a number defined 
by the following process: Starting with any positive integer, replace the 
number by the sum of the squares of its digits in base-ten, and repeat the 
process until the number either equals 1 (where it will stay), or it loops 
endlessly in a cycle that does not include 1.

if (IsHappyNumber (19))
    Console.WriteLine("152 is a Happy number");

if ( ! IsHappyNumber (8))
    Console.WriteLine("8 is not a Happy number");

 */

using System;

public class FunctionIsHarshadNumber
{
    public static bool IsHappyNumber(int num)
    {
        string numberAsString = Convert.ToString(num);
        int sum = 0;
        foreach (char c in numberAsString)
        {
            int digit = Convert.ToInt32(Convert.ToString(c));
            sum += digit*digit;
        }
        if (sum == 1)
            return true;
        else if (sum == 4)
            return false;
        else return IsHappyNumber(sum);
    }

    public static void Main()
    {
        if (IsHappyNumber(19))
            Console.WriteLine("19 is a Happy number");

        if (!IsHappyNumber(8))
            Console.WriteLine("8 is not a Happy number");
    }
}
