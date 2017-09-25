/*
Write a simulation of a shopping process, in which the user
must enter the amount and price, and the computer will display
the total. The program wille finish when the user enters 0
for the amount, and then it will display the grand total :
 
Enter amount: 5
Enter price: 10
Total: 50
Enter amount: 7
Enter price: 2
Total: 14
Enter amount: 0
Grand total: 64
*/

using System;

public class GrandTotal
{
    public static void Main()
    {
        int total = 0;
        int grandTotal = 0;
        int amount, price = 0;
        
        Console.Write("Enter amount: ");
        amount = Convert.ToInt32(Console.ReadLine());
        if (amount != 0)
        {
            Console.Write("Enter price: ");
            price = Convert.ToInt32(Console.ReadLine());
        }
            
        while (amount != 0)
        {
            total = amount * price;
            if (amount != 0)
                Console.WriteLine("Total: {0}", total);
            grandTotal = grandTotal + total;
            
            Console.Write("Enter amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            if (amount != 0)
            {
                Console.Write("Enter price: ");
                price = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Grand total: {0}", grandTotal);
    }
}
