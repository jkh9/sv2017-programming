// Write a C# program to display the even numbers, 
// from a user entered number down to 0

// Victor Tebar

using System;

public class Ejer51
{
    public static void Main()
    {
        int count;
        
        Console.Write("Enter a number: ");
        count = Convert.ToInt32(Console.ReadLine());
        
        // Let's test all the numbers
        // and display only the even ones
        while(count >= 0)
        {
            if(count % 2 == 0)
                Console.Write("{0} ",count);
            count = count - 1;
        }
    }
}

