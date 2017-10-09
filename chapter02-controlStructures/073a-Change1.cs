/*
Create a C# program to return the change of a purchase, using coins (or bills) 
as large as possible. Assume we have an unlimited amount of coins (or bills) of 
100, 10, 5, and 1, and there are no decimal places. Thus, the execution could 
be something like this:

Price? 272
Paid? 300
Your change is 28: 10 10 5 1 1 1
*/


using System;

public class GiveChange
{
    public static void Main()
    {
        int amount, paid, change;
        
        Console.Write("Enter amount: ");
        amount = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter paid: ");
        paid = Convert.ToInt32(Console.ReadLine());
        
        change = paid - amount;
        
        while (change >= 100)
        {
            Console.Write("100 ");
            change = change - 100;
        }
        
        while (change >= 10)
        {
            Console.Write("10 ");
            change = change - 10;
        }
        
        while (change >= 5)
        {
            Console.Write("5 ");
            change = change - 5;
        }
        
        while (change >= 1)
        {
            Console.Write("1 ");
            change = change - 1;
        }

        Console.WriteLine();
    }
}
