/*

Function SumDigits
Luis Selles

*/

using System;

public class ExNumber
{
    public static int SumDigits(int number)
    {
        string n = Convert.ToString(number);
        int sum = 0;
        foreach(char num in n)
        {
            sum = sum + Convert.ToInt32(Convert.ToString(num));
        }
        return sum;
    }
    
    public static void Main()
    {
        Console.WriteLine(SumDigits(123));
    }
}
