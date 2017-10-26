// Search in an array
// Version 2: Counter

using System;

public class Ex147b
{
    public static void Main()
    {
        string[] monthName = {"January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", 
            "December"};
        
        Console.Write("Name of the month? ");
        string name = Console.ReadLine();
        
        int occurences = 0;
        for(int i = 0; i < 12; i++)
        {
            if (monthName[i] == name)
                occurences ++;
        }
        if (occurences > 0)
            Console.WriteLine("Found!");
        else
            Console.WriteLine("Not found!");
    }
}
