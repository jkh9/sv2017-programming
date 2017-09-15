// Guillermo Pastor Pastor
// Ask for two numbers and then sum them

using System;

public class SumTwoNumbers
{
    public static void Main()
    {
        int a, b;
        int sum;
        
        Console.WriteLine("Enter a number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number");
        b = Convert.ToInt32(Console.ReadLine());
        
        sum = a + b;
        
        Console.WriteLine("Their sum is");
        Console.WriteLine( sum ); 
    }
}
