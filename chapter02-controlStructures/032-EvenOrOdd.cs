// Marcos Cervantes
// Even or odd

using System;

public class EvenOrOdd
{
    public static void Main()
    {
        int number;
        
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        if (number % 2 == 0)
            Console.WriteLine("Your number is  even");
        else
            Console.WriteLine("Your number is odd");
    }
}
