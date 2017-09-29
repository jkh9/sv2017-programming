// Victor Tebar
// Counts how many digits has a number

using System;

public class CountDigits
{
    public static void Main()
    {
        int num,count = 0;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        while(num > 0)
        {
            num = num / 10;
            count = count + 1;
        }
        
        if (count == 0)   // Special case: number 0 has 1 digit
            count = 1;
        
        Console.WriteLine("The number has {0} digits",count);
    }
}
