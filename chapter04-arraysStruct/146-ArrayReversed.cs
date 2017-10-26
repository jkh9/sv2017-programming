// Gonzalo Martinez
// Array reversed

using System;

public class Ex146
{
    public static void Main()
    {
        string[] monthName = {"January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", 
            "December"};
        
        for(int i = 11; i >= 0; i--)
        {
            Console.Write(monthName[i]+" ");
        }
        Console.WriteLine();
    }
}
