/*
Create an array containing the names of the months of the year.  
Display the name of the fifth month should be "May") and then
display all the months on screen.
*/

//~ Guillermo Pastor Pastor

using System;

public class DaysInMonth1
{
    public static void Main()
    {
        string[] monthNames= {"January","February","March",
            "April","May","June","July","August","September","October",
            "November","December"};
        
        Console.WriteLine("The fifth month is " + monthNames[4]);
        Console.Write("And the names of all the months are: ");
        for (int i = 0; i < 12; i++)
        {
            Console.Write(monthNames[i]+" ");
        }
        Console.WriteLine();
    }
}
