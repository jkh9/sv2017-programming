// Create a C# program to ask the user for three integer numbers a, b, c 
// and display:
// 
// The first number incremented 
// The second number, after dividing it by 3 
// The third number, after decreasing it by 5
// 
// Finally, create two new variable d1 and e1, both with the value 8. 
// Create d2 and assign it the value of d1, predecremented, and e2 
// with the value of e1, postdecremented. Display d1, e1, d2 and e2.

// brandon blasco del cid

using System;

public class AbbreviatedOperations
{
    public static void Main()
    {
        int a, b, c;
        int d1, e1, d2, e2;
        
        Console.Write("Enter a number: ");
        a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another number: ");
        b =  Convert.ToInt32(Console.ReadLine());
        
        Console.Write("And the last number: ");
        c =  Convert.ToInt32(Console.ReadLine());
        
        a++;
        Console.WriteLine("a = "+a);
        
        b /= 3;
        Console.WriteLine("b = "+b);
        
        c -= 5;
        Console.WriteLine("c = "+c);
        
        d1 = e1 = 8;
        d2 = --d1;
        e2 = e1--;
        Console.WriteLine("d1 = "+d1);
        Console.WriteLine("d2 = "+d2);
        Console.WriteLine("e1 = "+e1);
        Console.WriteLine("e2 = "+e2);
    }
}
