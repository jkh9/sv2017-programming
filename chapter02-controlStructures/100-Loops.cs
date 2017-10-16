// Exercise 100: Loops
// Pedro Luis Coloma

using System;

public class Loops
{
    public static void Main()
    {
        int first,second,i;
        
        Console.Write("Enter lower limit: ");
        first = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter upper limit: ");
        second = Convert.ToInt32(Console.ReadLine());
        
        // We must start with an even number
        if (first %2 != 0) 
            first ++;

        // First loop, for, step of 1
        for (i = first; i <= second; i++)
            if (i%2 == 0)
                Console.Write("{0} ",i);
        Console.WriteLine();
        
        // Second loop, for, step of 2
        for (i = first; i <= second ;i += 2)
            Console.Write("{0} ",i);
        Console.WriteLine();
        
        // Third loop, while
        i = first;
        while (i <= second)
        {
            Console.Write("{0} ",i);
            i += 2;
        }
        Console.WriteLine();
        
        // Fourth loop, do-while
        i=first;
        do
        {
            Console.Write("{0} ",i);
            i=i+2;           
        } while (i<=second);
                
    }
}
