// Miles to meters (V2b: {0})

using System;

public class MilesToMeters2
{
    public static void Main()
    {
        int miles;
        
        Console.Write("How many miles? ");
        miles = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("{0} land miles are {1} m", 
			miles, miles * 1609 );
        Console.WriteLine("{0} nautical miles are {1} m", 
			miles, miles * 1852 );
    }   
}   
