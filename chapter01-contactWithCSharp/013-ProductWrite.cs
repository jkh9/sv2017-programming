//Javier herreros Pozo
using System;

public class ProductOfTwo
{
    public static void Main()
    {
        int a, b, product;
        
        Console.WriteLine("Enter a number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        b = Convert.ToInt32(Console.ReadLine());
        
        product = a * b;
        
        Console.Write("The product of ");
        Console.Write(a);
        Console.Write(" and ");
        Console.Write(b);
        Console.Write(" is ");
        Console.WriteLine(product);
    }
}
