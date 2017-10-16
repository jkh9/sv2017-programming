// Exercise 099: Power
// Moisés Encinas
 
using System;

public class Power
{
    public static void Main()
    {
        int result = 1;
        
        Console.Write("Base? ");
        int b = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Exponent? ");
        int e = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < e; i++)
            result = result * b;
        
        Console.WriteLine(result);
    }
}
