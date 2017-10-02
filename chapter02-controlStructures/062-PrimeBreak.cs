// Is a number prime? (v2: break)

using System;

public class IsPrime
{
    public static void Main()
    {
        int num, divider;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        for (divider = 2; divider <= num-1; divider++)
        {
            if(num % divider == 0)
            {
                Console.WriteLine("{0} is not a prime.",num);
                break;
            }
        }
        
        if (divider == num) 
            Console.WriteLine("{0} is a prime.",num);
        
        // Special case
        if (num == 1) 
            Console.WriteLine("1 is not a prime.");
    }
}
