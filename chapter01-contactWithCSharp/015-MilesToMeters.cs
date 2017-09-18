// Miles to meters

using System;

public class MilesToMeters
{
    public static void Main()
    {
        int miles;
        
        Console.Write("How many miles? ");
        miles = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("If land miles: ");
        Console.Write( miles * 1609 );
        Console.WriteLine(" m");
        
        Console.Write("If nautical miles: ");
        Console.Write( miles * 1852 );
        Console.WriteLine(" m");
    }   
}   
