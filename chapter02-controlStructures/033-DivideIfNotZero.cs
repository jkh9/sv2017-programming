// Divide if not zero

using System;

public class DidiveIfNotZero
{
    public static void Main()
    {
        int n1, n2, division;
        
        Console.Write("Enter first number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if(n2 == 0)
            Console.WriteLine("I cannot divide by zero");
        else
        {
            division = n1 / n2;
            Console.WriteLine("The division is {0}", division);        
        }
    }
}
