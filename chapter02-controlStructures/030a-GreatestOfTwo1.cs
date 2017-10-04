/*
    Brandon Blasco Del Cid
    If5: Greatest of two
*/
using System;

class If5
{
    static void Main()
    {
        int num1, num2;
        
        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if(num > num2)
            Console.WriteLine("The greatest number is {0}", num1);
        else
            Console.WriteLine("The greatest number is {0}", num2);
    }
}
