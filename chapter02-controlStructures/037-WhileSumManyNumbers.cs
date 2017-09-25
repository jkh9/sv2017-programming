/*
 * Raul Gogna
 * Suma
 */

using System;

public class Ex37
{
    public static void Main()
    {
        int sum = 0;
        int n;
        
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
            
        while (n != 0)
        {
            sum = sum + n;
            Console.WriteLine("The sum so far is: {0}", 
                sum);
            Console.Write("Enter an other number: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
