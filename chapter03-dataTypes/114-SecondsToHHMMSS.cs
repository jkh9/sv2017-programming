// Seconds to HH:MM:SS
// Querubin Santana

using System;

public class Time
{
    public static void Main()
    {
        uint secs, mins, hours;
        
        Console.Write("Seconds? ");
        secs= Convert.ToUInt32(Console.ReadLine());
        
        hours= secs / 3600;
        mins= (secs % 3600) / 60;
        secs= (secs % 3600) % 60;
        
        Console.WriteLine(hours.ToString("00")
            +":"+mins.ToString("00")+":"+secs.ToString("00"));
    }
}
