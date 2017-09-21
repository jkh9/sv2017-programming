/*
 * Write a C# program to calculate and display 
 * the average of four integer numbers entered by the user. 
 */

// Miguel García Gil
using System;

public class Average
{
    public static void Main()
    {
        int num1, num2, num3, num4;
        int average;
        
        Console.Write ("Enter first number: ");
        num1 = Convert.ToInt32 (Console.ReadLine());
        
        Console.Write ("Enter second number: ");
        num2 = Convert.ToInt32 (Console.ReadLine());
        
        Console.Write ("Enter third number: ");
        num3 = Convert.ToInt32 (Console.ReadLine());
        
        Console.Write ("Enter fourth number: ");
        num4 = Convert.ToInt32 (Console.ReadLine());
        
        average = (num1+num2+num3+num4) / 4;
        
        Console.Write ("The average is: ");
        Console.WriteLine (average);
    }
}
