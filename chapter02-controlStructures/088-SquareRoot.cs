// Square root approximation
// Javier Cases Sempere

using System;

public class SquareRoot
{
    public static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int root = 0;
        
        while (root * root < number)
            root++;
        
        if (root * root > number)
            root--;

        Console.WriteLine("Its (integer) square root is {0}",
            root);
    }
}
