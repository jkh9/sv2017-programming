// Miles to meters (V2: {0})

using System;

public class MilesToMeters2
{
    public static void Main()
    {
        int miles;
        
        Console.Write("How many miles? ");
        miles = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("If land miles: {0} m", miles * 1609 );
        Console.WriteLine("If nautical miles: {0} m", miles * 1852 );
    }   
}   
