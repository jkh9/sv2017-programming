// Moisex Encinas
/*
 * If amount or Price are 0 the programme shows the grand total
 */

using System;
public class Ex041
{
    public static void Main()
    {
        int grandTotal = 0;
        int amount, price, total;
        
        Console.Write("Amount?: ");
        amount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Price?: ");
        price = Convert.ToInt32(Console.ReadLine());
        
        while (!((amount == 0) || (price == 0)))
        {
            total = amount * price;            
            Console.WriteLine("Total: {0} ", total);
            grandTotal = grandTotal + total;
            
            Console.Write("Amount?: ");
            amount = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Price?: ");
            price = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Grand total: {0}", grandTotal);
    }
}
