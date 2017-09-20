// Gonzalo Martinez
// Speed conversion

using System;

public class SpeedConverter
{
    public static void Main()
    {
        int miles, sec;
        
        Console.Write("How many miles?: ");
        miles = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("How many seconds?: ");
        sec = Convert.ToInt32(Console.ReadLine());
                
        Console.Write("{0} miles in {1} seconds = ", miles, sec);
        Console.Write("{0} m/s, ", (miles * 1609) / sec);
        Console.Write("{0} km/h, ", (((miles * 1609) / sec) * 3600) / 1000);
        Console.Write("{0} mi/h", (miles * 3600) / sec);
        
    }
}
