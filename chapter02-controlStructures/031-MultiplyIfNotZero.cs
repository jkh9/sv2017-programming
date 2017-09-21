// Gonzalo Martinez
// Checks if it's a zero and then multiplies

using System;

public class Compare2
{
    public static void Main()
    {
        int number1, number2, product;
        
        Console.Write("Insert a number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        
        if(number1 == 0)
            Console.WriteLine("The product is zero");
        else
        {
            Console.Write("Insert another number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            product = number1 * number2;
            
            Console.Write("The product of {0} and {1} is {2}", number1, number2, 
                product);        
        }
    }
}
