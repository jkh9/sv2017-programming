// Create a program to display certain values of the function y = x2 - 2x + 1 
// (using integer numbers for x, ranging from -10 to +10)

//Pedro Luis Coloma

using System;

public class WorkingTime
{
    public static void Main()
    {
        int x, y;
        for (x = -10; x <= 10 ; x++)
        {
            y = x*x - 2*x + 1;
            Console.WriteLine("{0} : {1}", x, y);            
        }
    }
}
