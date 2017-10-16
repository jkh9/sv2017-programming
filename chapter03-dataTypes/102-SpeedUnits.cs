//LUCÍA NAVARRO VÉLEZ
//MILES METERS SECONDS KILOMETERS
using System;

public class SpeedUnits
{
    public static void Main()
    {
        double miles, seconds;
        double metersPerMile = 1609.34;
        
        Console.WriteLine("How many miles?");
        miles = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many seconds?");
        seconds = Convert.ToInt32(Console.ReadLine());
        
        double meters = metersPerMile*miles;
        double speedmih = miles/(seconds/3600);
        double speedms = meters/seconds;
        double speedkmh = (meters/1000)/(seconds/3600);
        
        Console.WriteLine("{0} miles / hour",speedmih);
        Console.WriteLine("{0} meters / seconds",speedms);
        Console.WriteLine("{0} kilometers / hour",speedkmh);
    }
}
