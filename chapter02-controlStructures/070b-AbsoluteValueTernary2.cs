// Almudena Lopez Sanchez
// Absolute value
using System;
public class AbsoluteValue
{
    public static void Main()
    {
        int num;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        // First with if and else
        if (num <= 0)
            Console.WriteLine("Absolute value: {0}", num * -1);
        else 
            Console.WriteLine("Absolute value: {0}", num);
        
        // With contional operator
        Console.WriteLine ("Absolute Value: {0}", num <= 0 ? num * -1 : num);
    }
}
