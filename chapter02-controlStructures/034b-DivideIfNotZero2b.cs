// Divide if not zero; ask once more if it is (version 2)
// Guillermo Pastor Pastor

using System;

public class DivideIfNotZero
{
    public static void Main()
    {
        int n1, n2, division;
        
        Console.Write("Enter first number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if ( n2 == 0 )
        {
            Console.WriteLine("I cannot divide by zero");
            
            Console.Write("Enter second number again: ");
            n2 = Convert.ToInt32(Console.ReadLine());
        }
        division = n1 / n2;
        Console.WriteLine("The division is {0}",division);
    }
}
