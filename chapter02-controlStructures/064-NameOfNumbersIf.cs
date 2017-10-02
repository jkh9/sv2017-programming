// Marcos Cervantes
// Name of the numbers
using System;
public class NameOfTheNumbers
{
    public static void Main()
    {
        Console.Write("Enter a number between 1 and 5: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number == 1)
            Console.Write("ONE");
        else if (number == 2)
            Console.Write("TWO");
        else if (number == 3)
            Console.Write("THREE");
        else if (number == 4)
            Console.Write("FOUR");
        else if (number == 5)
            Console.Write("FIVE");
        else 
            Console.Write("???");
    }
}
        
        


