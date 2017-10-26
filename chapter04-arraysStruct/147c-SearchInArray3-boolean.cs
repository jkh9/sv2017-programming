// Search in an array
// Version 3: boolean

using System;

public class Ex147c
{
    public static void Main()
    {
        string[] monthName = {"January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", 
            "December"};
        
        Console.Write("Name of the month? ");
        string name = Console.ReadLine();
        
        bool found = false;
        for(int i = 0; i < 12; i++)
        {
            if (monthName[i] == name)
                found = true;
        }
        if (found)
            Console.WriteLine("Found!");
        else
            Console.WriteLine("Not found!");
    }
}
