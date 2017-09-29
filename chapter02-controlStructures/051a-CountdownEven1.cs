// Write a C# program to display the even numbers, 
// from a user entered number down to 0

// Javier Cases Sempere

using System;

public class Ex51
{
    public static void Main()
    {
        int n;
        
        Console.Write("Enter a Number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        // If the number is odd, we must decrease it
        if (n % 2 != 0)
            n = n - 1;
        
        // And then we can proceed, decreasing two units each time
        while (n >= 0)
        {
            Console.Write("{0} ", n);
            n = n - 2;
        }
    }
}
