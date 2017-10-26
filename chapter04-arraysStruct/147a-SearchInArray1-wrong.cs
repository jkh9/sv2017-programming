// Search in an array
// Version 1: -- WRONG --

using System;

public class Ex147a
{
    public static void Main()
    {
        string[] monthName = {"January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", 
            "December"};
        
        Console.Write("Name of the month? ");
        string name = Console.ReadLine();
        
        for(int i = 0; i < 12; i++)
        {
            if (monthName[i] == name)
                Console.WriteLine("Found!");
            else
                Console.WriteLine("Not found!");
        }
    }
}
