// Moisex Encinas
/*
 * Count many numbers 
 */

using System;
public class Ex038
{
    public static void Main()
    {
        int count = 0;
        int n;
        
        Console.Write("Insert a number : ");
        n = Convert.ToInt32(Console.ReadLine());
        
        while (n != 0)
        {
            count = count + 1;
            Console.WriteLine("The count so far is: {0}", count);
            
            Console.Write("Insert a number: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
