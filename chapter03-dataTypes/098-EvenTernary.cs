// Exercise 098: Is even? ternary operator
// Miguel García Gil

using System;

public class PiAprox
{
    public static void Main()
    {
        int even, number;
        
        Console.Write ("Number? ");
        number = Convert.ToInt32 (Console.ReadLine());
        
        even = number % 2 == 0 ? 1 : 0;
    }
}
