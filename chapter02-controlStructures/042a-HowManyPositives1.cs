/* 
    Compare numbers
    Francisco Sabater Villora, 2017
*/

using System;
public class HowManyPositives
{
    public static void Main()
    {
        int num1, num2;
        
        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if( ( num1 > 0 ) && ( num2 > 0 ) )
        {
            Console.WriteLine("All two are positives");
        }
        else if ( ( num1 > 0 ) || ( num2 > 0 ) )
        {
            Console.WriteLine("One of two is positive");
        }
        else
            Console.WriteLine("No one is positive");
    }
}
